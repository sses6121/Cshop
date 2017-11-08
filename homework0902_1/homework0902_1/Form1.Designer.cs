namespace homework0902_1 {
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ExplainButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.LeftToRButton = new System.Windows.Forms.Button();
            this.RightToLButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TitleLabel.Location = new System.Drawing.Point(123, 48);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(212, 48);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "農夫過河";
            // 
            // ExplainButton
            // 
            this.ExplainButton.Location = new System.Drawing.Point(341, 56);
            this.ExplainButton.Name = "ExplainButton";
            this.ExplainButton.Size = new System.Drawing.Size(91, 40);
            this.ExplainButton.TabIndex = 1;
            this.ExplainButton.Text = "說明";
            this.ExplainButton.UseVisualStyleBackColor = true;
            this.ExplainButton.Click += new System.EventHandler(this.ExplainButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(12, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(156, 172);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(285, 135);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(156, 172);
            this.listBox2.TabIndex = 3;
            // 
            // LeftToRButton
            // 
            this.LeftToRButton.Location = new System.Drawing.Point(174, 153);
            this.LeftToRButton.Name = "LeftToRButton";
            this.LeftToRButton.Size = new System.Drawing.Size(83, 35);
            this.LeftToRButton.TabIndex = 4;
            this.LeftToRButton.Text = "--->";
            this.LeftToRButton.UseVisualStyleBackColor = true;
            this.LeftToRButton.Click += new System.EventHandler(this.LeftToRButton_Click);
            // 
            // RightToLButton
            // 
            this.RightToLButton.Location = new System.Drawing.Point(174, 231);
            this.RightToLButton.Name = "RightToLButton";
            this.RightToLButton.Size = new System.Drawing.Size(83, 35);
            this.RightToLButton.TabIndex = 5;
            this.RightToLButton.Text = "<--";
            this.RightToLButton.UseVisualStyleBackColor = true;
            this.RightToLButton.Click += new System.EventHandler(this.RightToLButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 315);
            this.Controls.Add(this.RightToLButton);
            this.Controls.Add(this.LeftToRButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ExplainButton);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ExplainButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button LeftToRButton;
        private System.Windows.Forms.Button RightToLButton;
    }
}

