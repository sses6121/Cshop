namespace homework0831_03 {
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
            this.label2 = new System.Windows.Forms.Label();
            this.NTDtextBox = new System.Windows.Forms.TextBox();
            this.NTDUStextBox = new System.Windows.Forms.TextBox();
            this.NTDUSRadioButton = new System.Windows.Forms.RadioButton();
            this.USNTDRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入美金匯率";
            // 
            // NTDtextBox
            // 
            this.NTDtextBox.Location = new System.Drawing.Point(46, 75);
            this.NTDtextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NTDtextBox.Name = "NTDtextBox";
            this.NTDtextBox.Size = new System.Drawing.Size(142, 33);
            this.NTDtextBox.TabIndex = 2;
            // 
            // NTDUStextBox
            // 
            this.NTDUStextBox.Location = new System.Drawing.Point(271, 75);
            this.NTDUStextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NTDUStextBox.Name = "NTDUStextBox";
            this.NTDUStextBox.Size = new System.Drawing.Size(142, 33);
            this.NTDUStextBox.TabIndex = 3;
            // 
            // NTDUSRadioButton
            // 
            this.NTDUSRadioButton.AutoSize = true;
            this.NTDUSRadioButton.Location = new System.Drawing.Point(24, 72);
            this.NTDUSRadioButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NTDUSRadioButton.Name = "NTDUSRadioButton";
            this.NTDUSRadioButton.Size = new System.Drawing.Size(133, 25);
            this.NTDUSRadioButton.TabIndex = 4;
            this.NTDUSRadioButton.TabStop = true;
            this.NTDUSRadioButton.Text = "台幣換美金";
            this.NTDUSRadioButton.UseVisualStyleBackColor = true;
            this.NTDUSRadioButton.CheckedChanged += new System.EventHandler(this.NTDUSRadioButton_CheckedChanged);
            // 
            // USNTDRadioButton
            // 
            this.USNTDRadioButton.AutoSize = true;
            this.USNTDRadioButton.Location = new System.Drawing.Point(191, 72);
            this.USNTDRadioButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.USNTDRadioButton.Name = "USNTDRadioButton";
            this.USNTDRadioButton.Size = new System.Drawing.Size(133, 25);
            this.USNTDRadioButton.TabIndex = 5;
            this.USNTDRadioButton.TabStop = true;
            this.USNTDRadioButton.Text = "美金換台幣";
            this.USNTDRadioButton.UseVisualStyleBackColor = true;
            this.USNTDRadioButton.CheckedChanged += new System.EventHandler(this.USNTDRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.USNTDRadioButton);
            this.groupBox1.Controls.Add(this.NTDUSRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(46, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(367, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請選擇";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "請輸入金額匯率，並選擇對換幣別";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NTDUStextBox);
            this.Controls.Add(this.NTDtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NTDtextBox;
        private System.Windows.Forms.TextBox NTDUStextBox;
        private System.Windows.Forms.RadioButton NTDUSRadioButton;
        private System.Windows.Forms.RadioButton USNTDRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}

