namespace homework_0828_1 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.BlackBGButton = new System.Windows.Forms.Button();
            this.YellowBGButton = new System.Windows.Forms.Button();
            this.RedFontButton = new System.Windows.Forms.Button();
            this.BlueFtButton = new System.Windows.Forms.Button();
            this.BoldButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(166, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "金雞報喜";
            // 
            // BlackBGButton
            // 
            this.BlackBGButton.Location = new System.Drawing.Point(28, 183);
            this.BlackBGButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BlackBGButton.Name = "BlackBGButton";
            this.BlackBGButton.Size = new System.Drawing.Size(163, 75);
            this.BlackBGButton.TabIndex = 1;
            this.BlackBGButton.Text = "黑底";
            this.BlackBGButton.UseVisualStyleBackColor = true;
            this.BlackBGButton.Click += new System.EventHandler(this.BlackBGButton_Click);
            // 
            // YellowBGButton
            // 
            this.YellowBGButton.Location = new System.Drawing.Point(28, 312);
            this.YellowBGButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.YellowBGButton.Name = "YellowBGButton";
            this.YellowBGButton.Size = new System.Drawing.Size(163, 75);
            this.YellowBGButton.TabIndex = 2;
            this.YellowBGButton.Text = "黃底";
            this.YellowBGButton.UseVisualStyleBackColor = true;
            this.YellowBGButton.Click += new System.EventHandler(this.YellowBGButton_Click);
            // 
            // RedFontButton
            // 
            this.RedFontButton.Location = new System.Drawing.Point(223, 183);
            this.RedFontButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RedFontButton.Name = "RedFontButton";
            this.RedFontButton.Size = new System.Drawing.Size(163, 75);
            this.RedFontButton.TabIndex = 3;
            this.RedFontButton.Text = "紅字";
            this.RedFontButton.UseVisualStyleBackColor = true;
            this.RedFontButton.Click += new System.EventHandler(this.RedFontButton_Click);
            // 
            // BlueFtButton
            // 
            this.BlueFtButton.Location = new System.Drawing.Point(223, 312);
            this.BlueFtButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BlueFtButton.Name = "BlueFtButton";
            this.BlueFtButton.Size = new System.Drawing.Size(163, 75);
            this.BlueFtButton.TabIndex = 4;
            this.BlueFtButton.Text = "藍字";
            this.BlueFtButton.UseVisualStyleBackColor = true;
            this.BlueFtButton.Click += new System.EventHandler(this.BlueFtButton_Click);
            // 
            // BlodButton
            // 
            this.BoldButton.Location = new System.Drawing.Point(415, 183);
            this.BoldButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(163, 75);
            this.BoldButton.TabIndex = 5;
            this.BoldButton.Text = "粗體";
            this.BoldButton.UseVisualStyleBackColor = true;
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(415, 312);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 75);
            this.button6.TabIndex = 6;
            this.button6.Text = "斜體";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 401);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.BoldButton);
            this.Controls.Add(this.BlueFtButton);
            this.Controls.Add(this.RedFontButton);
            this.Controls.Add(this.YellowBGButton);
            this.Controls.Add(this.BlackBGButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BlackBGButton;
        private System.Windows.Forms.Button YellowBGButton;
        private System.Windows.Forms.Button RedFontButton;
        private System.Windows.Forms.Button BlueFtButton;
        private System.Windows.Forms.Button BoldButton;
        private System.Windows.Forms.Button button6;
    }
}

