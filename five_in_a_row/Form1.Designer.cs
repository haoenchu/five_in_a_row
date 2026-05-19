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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.chessboard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chessboard)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_start.Location = new System.Drawing.Point(12, 0);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(194, 28);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Visible = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click_1);
            // 
            // btn_end
            // 
            this.btn_end.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_end.Location = new System.Drawing.Point(233, 0);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(179, 28);
            this.btn_end.TabIndex = 2;
            this.btn_end.Text = "end";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Visible = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // chessboard
            // 
            this.chessboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chessboard.Enabled = false;
            this.chessboard.Image = global::five_in_a_row.Properties.Resources.checkerboard;
            this.chessboard.Location = new System.Drawing.Point(0, 0);
            this.chessboard.Name = "chessboard";
            this.chessboard.Size = new System.Drawing.Size(900, 900);
            this.chessboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chessboard.TabIndex = 0;
            this.chessboard.TabStop = false;
            this.chessboard.Click += new System.EventHandler(this.chessboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 900);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.chessboard);
            this.Name = "Form1";
            this.Text = "五子棋遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chessboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox chessboard;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_end;
    }
}

