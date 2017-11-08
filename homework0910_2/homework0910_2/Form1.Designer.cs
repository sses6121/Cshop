namespace homework0910_2 {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.playFileBtn = new System.Windows.Forms.Button();
            this.repeatBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(30, 110);
            this.OpenFileBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(134, 44);
            this.OpenFileBtn.TabIndex = 0;
            this.OpenFileBtn.Text = "開檔";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // playFileBtn
            // 
            this.playFileBtn.Location = new System.Drawing.Point(198, 110);
            this.playFileBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.playFileBtn.Name = "playFileBtn";
            this.playFileBtn.Size = new System.Drawing.Size(134, 44);
            this.playFileBtn.TabIndex = 1;
            this.playFileBtn.Text = "播放";
            this.playFileBtn.UseVisualStyleBackColor = true;
            this.playFileBtn.Click += new System.EventHandler(this.playFileBtn_Click);
            // 
            // repeatBtn
            // 
            this.repeatBtn.Location = new System.Drawing.Point(362, 110);
            this.repeatBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.repeatBtn.Name = "repeatBtn";
            this.repeatBtn.Size = new System.Drawing.Size(134, 44);
            this.repeatBtn.TabIndex = 2;
            this.repeatBtn.Text = "重複";
            this.repeatBtn.UseVisualStyleBackColor = true;
            this.repeatBtn.Click += new System.EventHandler(this.repeatBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(92, 196);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(134, 44);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "停止";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(294, 196);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(134, 44);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "結束";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 396);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.repeatBtn);
            this.Controls.Add(this.playFileBtn);
            this.Controls.Add(this.OpenFileBtn);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Button playFileBtn;
        private System.Windows.Forms.Button repeatBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

