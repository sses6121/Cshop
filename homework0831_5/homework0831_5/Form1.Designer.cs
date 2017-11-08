namespace homework0831_5 {
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CalButton = new System.Windows.Forms.Button();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this.SpendTextBox = new System.Windows.Forms.TextBox();
            this.ChagetextBox = new System.Windows.Forms.TextBox();
            this.textBox1000 = new System.Windows.Forms.TextBox();
            this.textBox500 = new System.Windows.Forms.TextBox();
            this.textBox100 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "收現:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "消費:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "找零:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "50元";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "100元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "500元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "1000元";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "10元";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "5元";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "1元";
            // 
            // CalButton
            // 
            this.CalButton.Location = new System.Drawing.Point(76, 432);
            this.CalButton.Name = "CalButton";
            this.CalButton.Size = new System.Drawing.Size(117, 51);
            this.CalButton.TabIndex = 10;
            this.CalButton.Text = "計算";
            this.CalButton.UseVisualStyleBackColor = true;
            this.CalButton.Click += new System.EventHandler(this.CalButton_Click);
            // 
            // CashTextBox
            // 
            this.CashTextBox.Location = new System.Drawing.Point(51, 90);
            this.CashTextBox.Name = "CashTextBox";
            this.CashTextBox.Size = new System.Drawing.Size(190, 33);
            this.CashTextBox.TabIndex = 11;
            this.CashTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CashTextBox.TextChanged += new System.EventHandler(this.CashTextBox_TextChanged);
            // 
            // SpendTextBox
            // 
            this.SpendTextBox.Location = new System.Drawing.Point(51, 198);
            this.SpendTextBox.Name = "SpendTextBox";
            this.SpendTextBox.Size = new System.Drawing.Size(190, 33);
            this.SpendTextBox.TabIndex = 12;
            this.SpendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpendTextBox.TextChanged += new System.EventHandler(this.SpendTextBox_TextChanged);
            // 
            // ChagetextBox
            // 
            this.ChagetextBox.Location = new System.Drawing.Point(51, 300);
            this.ChagetextBox.Name = "ChagetextBox";
            this.ChagetextBox.ReadOnly = true;
            this.ChagetextBox.Size = new System.Drawing.Size(190, 33);
            this.ChagetextBox.TabIndex = 13;
            this.ChagetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1000
            // 
            this.textBox1000.Location = new System.Drawing.Point(411, 54);
            this.textBox1000.Name = "textBox1000";
            this.textBox1000.ReadOnly = true;
            this.textBox1000.Size = new System.Drawing.Size(190, 33);
            this.textBox1000.TabIndex = 14;
            this.textBox1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox500
            // 
            this.textBox500.Location = new System.Drawing.Point(411, 104);
            this.textBox500.Name = "textBox500";
            this.textBox500.ReadOnly = true;
            this.textBox500.Size = new System.Drawing.Size(190, 33);
            this.textBox500.TabIndex = 15;
            this.textBox500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox100
            // 
            this.textBox100.Location = new System.Drawing.Point(411, 165);
            this.textBox100.Name = "textBox100";
            this.textBox100.ReadOnly = true;
            this.textBox100.Size = new System.Drawing.Size(190, 33);
            this.textBox100.TabIndex = 16;
            this.textBox100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(411, 220);
            this.textBox50.Name = "textBox50";
            this.textBox50.ReadOnly = true;
            this.textBox50.Size = new System.Drawing.Size(190, 33);
            this.textBox50.TabIndex = 17;
            this.textBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(411, 291);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(190, 33);
            this.textBox10.TabIndex = 18;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(411, 362);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(190, 33);
            this.textBox5.TabIndex = 19;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 435);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 33);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 667);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox50);
            this.Controls.Add(this.textBox100);
            this.Controls.Add(this.textBox500);
            this.Controls.Add(this.textBox1000);
            this.Controls.Add(this.ChagetextBox);
            this.Controls.Add(this.SpendTextBox);
            this.Controls.Add(this.CashTextBox);
            this.Controls.Add(this.CalButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CalButton;
        private System.Windows.Forms.TextBox CashTextBox;
        private System.Windows.Forms.TextBox SpendTextBox;
        private System.Windows.Forms.TextBox ChagetextBox;
        private System.Windows.Forms.TextBox textBox1000;
        private System.Windows.Forms.TextBox textBox500;
        private System.Windows.Forms.TextBox textBox100;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

