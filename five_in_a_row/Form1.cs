using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace five_in_a_row {
    public partial class Form1 : Form {

        int[,] board = new int[15, 15]; // 0: empty, 1: player, 2: AI
        int turn = 1; // 假設玩家是1，AI是2

        public Image GetPic(string poker_name) {
            return five_in_a_row.Properties.Resources.ResourceManager.GetObject(poker_name) as Image;
        }
        public Form1() {
            InitializeComponent();
            Initialbtn();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Initialbtn() {
            // chessboard 一格寬60*60，共15*15  可放棋子的位置 左上:(30,30) ~ 右下:(840,840)
            // bnt 正中心位置 (352, 417) size (195,75)
            btn_start.Visible = true;
            btn_start.Text = "開始遊戲";
            btn_start.Location = new Point(352, 417);
            btn_start.Size = new Size(195, 75);



            btn_end.Text = "再來一局";
            btn_end.Location = new Point(352, 417);
            btn_end.Size = new Size(195, 75);
            chessboard.MouseClick += new MouseEventHandler(MouseClick_play_chess);
        }

        private void btn_start_Click_1(object sender, EventArgs e) {
            btn_start.Visible = false;
            chessboard.Enabled = true;
        }

        private void btn_end_Click(object sender, EventArgs e) { // 重置遊戲狀態
            board = new int[15, 15]; // 重置棋盤
            turn = 1; // 重置玩家回合
            chessboard.Controls.Clear(); // 清除棋盤上的棋子
            chessboard.Enabled = true; // 重新啟用棋盤
            btn_end.Visible = false; // 隱藏結束按鈕

        }

        private void chessboard_Click(object sender, EventArgs e) {

        }

        private void draw_chess_on_board(int x, int y) {
            int localX = x * 60 + 30; // 將棋盤格坐標轉換為像素坐標
            int localY = y * 60 + 30;

            // 在棋盤上繪製棋子
            PictureBox chessPiece = new PictureBox();
            chessPiece.Size = new Size(50, 50); // 設定棋子大小
            chessPiece.Location = new Point(localX - 25, localY - 25); // 將棋子中心對齊到格子中心
            chessPiece.Image = (turn == 1) ? GetPic("black") : GetPic("white"); // 根據玩家顯示不同的棋子圖片
            chessPiece.SizeMode = PictureBoxSizeMode.StretchImage; // 調整圖片大小以適應棋子大小
            chessPiece.BackColor = Color.Transparent; // 設定背景為透明，以便棋子圖片顯示正常
            this.chessboard.Controls.Add(chessPiece); // 將棋子添加到棋盤上
        }

        private void MouseClick_play_chess(object sender, MouseEventArgs e) {
            // Local coordinates (relative to the top-left of the form

            int X = e.X / 60;
            int Y = e.Y / 60;
            draw_chess_on_board(X, Y);

            board[X, Y] = turn; // 將棋子放在棋盤上

            if (winning_condition(X, Y)) {
                string message = "";
                if (turn == 1)
                    message = "玩家獲勝！";
                else if (turn == 2)
                    message = "你輸了！";
                MessageBox.Show(message);
                chessboard.Enabled = false; // 禁止繼續下棋
                btn_end.Visible = true;
                return;
            }

           // MessageBox.Show($"Clicked at: X={X}, Y={Y}");

            turn = 2;
            AI_move();
            turn = 1;
        }

        private bool winning_condition(int x, int y) {
            int[,] directions = { { 1, 0 }, { 0, 1 }, { 1, 1 }, { 1, -1 } };

            for (int d = 0; d < 4; d++) {
                int dx = directions[d, 0];
                int dy = directions[d, 1];
                int count = 1;

                // 正方向
                for (int i = 1; i <= 4; i++) {
                    int nx = x + dx * i, ny = y + dy * i;
                    if (nx < 0 || nx > 14 || ny < 0 || ny > 14 || board[nx, ny] != turn) break;
                    count++;
                }
                // 反方向
                for (int i = 1; i <= 4; i++) {
                    int nx = x - dx * i, ny = y - dy * i;
                    if (nx < 0 || nx > 14 || ny < 0 || ny > 14 || board[nx, ny] != turn) break;
                    count++;
                }

                if (count >= 5) return true;
            }
            return false;
        }

        private int evaluate_score(int black, int white) {
            int score = 0;

            // black = 玩家(1) 的連線數 → 防守分要高！
            if (black == 1) score += 10;
            if (black == 2) score += 50;
            if (black == 3) score += 800;
            if (black == 4) score += 9000;  // 玩家快贏了，一定要擋！

            // white = AI(2) 的連線數 → 進攻分
            if (white == 2) score += 100;
            if (white == 3) score += 1000;
            if (white == 4) score += 10000; // AI 快贏了，優先下這裡

            return score;
        }
        private int evaluate_line(int x, int y) {
            int score = 0;
            int[,] directions = { { 1, 0 }, { 0, 1 }, { 1, 1 }, { 1, -1 } };

            for (int d = 0; d < 4; d++) {
                int dx = directions[d, 0];
                int dy = directions[d, 1];

                // 計算 AI(2) 在這個方向的連線數
                int aiCount = count_line(x, y, dx, dy, 2);
                // 計算玩家(1) 在這個方向的威脅數
                int playerCount = count_line(x, y, dx, dy, 1);

                score += evaluate_score(playerCount, aiCount);
            }
            return score;
        }

        // 計算某方向，某玩家的連線數（不含當前空格本身）
        private int count_line(int x, int y, int dx, int dy, int player) {
            int count = 0;

            // 正方向
            for (int i = 1; i <= 4; i++) {
                int nx = x + dx * i, ny = y + dy * i;
                if (nx < 0 || nx > 14 || ny < 0 || ny > 14) break;
                if (board[nx, ny] == player) count++;
                else break; // 遇到空格或對手就停
            }
            // 反方向
            for (int i = 1; i <= 4; i++) {
                int nx = x - dx * i, ny = y - dy * i;
                if (nx < 0 || nx > 14 || ny < 0 || ny > 14) break;
                if (board[nx, ny] == player) count++;
                else break;
            }

            return count;
        }

        private void AI_move() {
            // AI的移動邏輯

            int[,] score =new int[15, 15];// 評分矩陣，評估每個位置的分數
            int maxScore = int.MinValue; // 用於追蹤最高分數
            int bestX = 0, bestY = 0; // 用於追蹤最佳位置

            for (int x = 0; x < 15; x++) {
                for (int y = 0; y < 15; y++) {
                    if (board[x, y] == 0) { // 只評估空格
                        score[x, y] = evaluate_line(x,y);
                        
                        if (score[x, y] > maxScore) {
                            maxScore = score[x, y];
                            bestX = x;
                            bestY = y;
                        }
                    }
                }
            }
            
            board[bestX, bestY] = turn; // 將AI的棋子放在棋盤上
            draw_chess_on_board(bestX, bestY);

            if (winning_condition(bestX, bestY)) {
                string message = "";
                if (turn == 1)
                    message = "玩家獲勝！";
                else if (turn == 2)
                    message = "你輸了！";
                MessageBox.Show(message);
                chessboard.Enabled = false; // 禁止繼續下棋
                btn_end.Visible = true;
                return;
            }

            return;
        }
    }
}
