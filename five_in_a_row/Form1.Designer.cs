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
            ((System.ComponentModel.ISupportInitialize)(this.chessboard)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_end
            // 
            this.btn_end.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_end.Location = new System.Drawing.Point(26, 35);
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
            // btn_single
            // 
            this.btn_single.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_single.Location = new System.Drawing.Point(26, 99);
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
            this.btn_double.Location = new System.Drawing.Point(26, 169);
            this.btn_double.Name = "btn_double";
            this.btn_double.Size = new System.Drawing.Size(194, 52);
            this.btn_double.TabIndex = 4;
            this.btn_double.Text = "double_btn";
            this.btn_double.UseVisualStyleBackColor = true;
            this.btn_double.Visible = false;
            this.btn_double.Click += new System.EventHandler(this.btn_double_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 900);
            this.Controls.Add(this.btn_double);
            this.Controls.Add(this.btn_single);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.chessboard);
            this.Name = "Form1";
            this.Text = "五子棋遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chessboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox chessboard;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button btn_single;
        private System.Windows.Forms.Button btn_double;
    }
}

