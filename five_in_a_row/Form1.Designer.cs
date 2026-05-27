namespace five_in_a_row {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.btn_end = new System.Windows.Forms.Button();
            this.chessboard = new System.Windows.Forms.PictureBox();
            this.btn_single = new System.Windows.Forms.Button();
            this.btn_double = new System.Windows.Forms.Button();
            this.MOD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.round = new System.Windows.Forms.Label();
            this.black_mention = new System.Windows.Forms.Label();
            this.white_mention = new System.Windows.Forms.Label();
            this.round_mention = new System.Windows.Forms.Label();
            this.MOD_output = new System.Windows.Forms.Label();
            this.tips = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chessboard)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_end
            // 
            this.btn_end.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_end.Location = new System.Drawing.Point(26, 118);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(194, 43);
            this.btn_end.TabIndex = 2;
            this.btn_end.Text = "end_btn";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Visible = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // chessboard
            // 
            this.chessboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chessboard.Enabled = false;
            this.chessboard.Image = global::five_in_a_row.Properties.Resources.checkerboard;
            this.chessboard.Location = new System.Drawing.Point(0, 83);
            this.chessboard.Name = "chessboard";
            this.chessboard.Size = new System.Drawing.Size(900, 900);
            this.chessboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chessboard.TabIndex = 0;
            this.chessboard.TabStop = false;
            this.chessboard.Click += new System.EventHandler(this.chessboard_Click);
            // 
            // btn_single
            // 
            this.btn_single.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_single.Location = new System.Drawing.Point(26, 167);
            this.btn_single.Name = "btn_single";
            this.btn_single.Size = new System.Drawing.Size(194, 51);
            this.btn_single.TabIndex = 3;
            this.btn_single.Text = "single_btn";
            this.btn_single.UseVisualStyleBackColor = true;
            this.btn_single.Visible = false;
            this.btn_single.Click += new System.EventHandler(this.btn_single_Click);
            // 
            // btn_double
            // 
            this.btn_double.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_double.Location = new System.Drawing.Point(26, 224);
            this.btn_double.Name = "btn_double";
            this.btn_double.Size = new System.Drawing.Size(194, 52);
            this.btn_double.TabIndex = 4;
            this.btn_double.Text = "double_btn";
            this.btn_double.UseVisualStyleBackColor = true;
            this.btn_double.Visible = false;
            this.btn_double.Click += new System.EventHandler(this.btn_double_Click);
            // 
            // MOD
            // 
            this.MOD.AutoSize = true;
            this.MOD.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MOD.Location = new System.Drawing.Point(8, 25);
            this.MOD.Name = "MOD";
            this.MOD.Size = new System.Drawing.Size(83, 35);
            this.MOD.TabIndex = 5;
            this.MOD.Text = "模式: ";
            this.MOD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(261, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "棋子顏色: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // round
            // 
            this.round.AutoSize = true;
            this.round.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.round.Location = new System.Drawing.Point(550, 25);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(76, 35);
            this.round.TabIndex = 7;
            this.round.Text = "回合:";
            this.round.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // black_mention
            // 
            this.black_mention.AutoSize = true;
            this.black_mention.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.black_mention.Location = new System.Drawing.Point(391, 11);
            this.black_mention.Name = "black_mention";
            this.black_mention.Size = new System.Drawing.Size(159, 26);
            this.black_mention.TabIndex = 8;
            this.black_mention.Text = "黑色的棋子是誰";
            this.black_mention.Visible = false;
            this.black_mention.Click += new System.EventHandler(this.black_Click);
            // 
            // white_mention
            // 
            this.white_mention.AutoSize = true;
            this.white_mention.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.white_mention.Location = new System.Drawing.Point(391, 46);
            this.white_mention.Name = "white_mention";
            this.white_mention.Size = new System.Drawing.Size(159, 26);
            this.white_mention.TabIndex = 9;
            this.white_mention.Text = "白色的棋子是誰";
            this.white_mention.Visible = false;
            this.white_mention.Click += new System.EventHandler(this.White_Click);
            // 
            // round_mention
            // 
            this.round_mention.AutoSize = true;
            this.round_mention.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.round_mention.Location = new System.Drawing.Point(623, 31);
            this.round_mention.Name = "round_mention";
            this.round_mention.Size = new System.Drawing.Size(96, 26);
            this.round_mention.TabIndex = 10;
            this.round_mention.Text = "誰的回合";
            this.round_mention.Visible = false;
            this.round_mention.Click += new System.EventHandler(this.round_mention_Click);
            // 
            // MOD_output
            // 
            this.MOD_output.AutoSize = true;
            this.MOD_output.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MOD_output.Location = new System.Drawing.Point(79, 31);
            this.MOD_output.Name = "MOD_output";
            this.MOD_output.Size = new System.Drawing.Size(159, 26);
            this.MOD_output.TabIndex = 11;
            this.MOD_output.Text = "現在是哪個模式";
            this.MOD_output.Visible = false;
            this.MOD_output.Click += new System.EventHandler(this.MOD_output_Click);
            // 
            // tips
            // 
            this.tips.AutoSize = true;
            this.tips.Font = new System.Drawing.Font("微軟正黑體", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tips.Location = new System.Drawing.Point(632, 57);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(66, 17);
            this.tips.TabIndex = 12;
            this.tips.Text = "*黑棋先手";
            this.tips.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(900, 983);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.MOD_output);
            this.Controls.Add(this.round_mention);
            this.Controls.Add(this.white_mention);
            this.Controls.Add(this.black_mention);
            this.Controls.Add(this.round);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MOD);
            this.Controls.Add(this.btn_double);
            this.Controls.Add(this.btn_single);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.chessboard);
            this.Name = "Form1";
            this.Text = "五子棋遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chessboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chessboard;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button btn_single;
        private System.Windows.Forms.Button btn_double;
        private System.Windows.Forms.Label MOD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Label black_mention;
        private System.Windows.Forms.Label white_mention;
        private System.Windows.Forms.Label round_mention;
        private System.Windows.Forms.Label MOD_output;
        private System.Windows.Forms.Label tips;
    }
}

