namespace homework0904_3 {
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
            this.Circlebutton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.TrapezoidButton = new System.Windows.Forms.Button();
            this.RtextBox = new System.Windows.Forms.TextBox();
            this.LtextBox = new System.Windows.Forms.TextBox();
            this.WtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "半徑";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "長";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "寬";
            // 
            // Circlebutton
            // 
            this.Circlebutton.Location = new System.Drawing.Point(424, 50);
            this.Circlebutton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Circlebutton.Name = "Circlebutton";
            this.Circlebutton.Size = new System.Drawing.Size(129, 55);
            this.Circlebutton.TabIndex = 3;
            this.Circlebutton.Text = "圓形面積";
            this.Circlebutton.UseVisualStyleBackColor = true;
            this.Circlebutton.Click += new System.EventHandler(this.Circlebutton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(424, 149);
            this.RectangleButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(129, 55);
            this.RectangleButton.TabIndex = 4;
            this.RectangleButton.Text = "矩形面積";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // TrapezoidButton
            // 
            this.TrapezoidButton.Location = new System.Drawing.Point(424, 251);
            this.TrapezoidButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TrapezoidButton.Name = "TrapezoidButton";
            this.TrapezoidButton.Size = new System.Drawing.Size(129, 55);
            this.TrapezoidButton.TabIndex = 5;
            this.TrapezoidButton.Text = "梯形面積";
            this.TrapezoidButton.UseVisualStyleBackColor = true;
            this.TrapezoidButton.Click += new System.EventHandler(this.TrapezoidButton_Click);
            // 
            // RtextBox
            // 
            this.RtextBox.Location = new System.Drawing.Point(155, 50);
            this.RtextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RtextBox.Name = "RtextBox";
            this.RtextBox.Size = new System.Drawing.Size(180, 33);
            this.RtextBox.TabIndex = 6;
            // 
            // LtextBox
            // 
            this.LtextBox.Location = new System.Drawing.Point(155, 121);
            this.LtextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LtextBox.Name = "LtextBox";
            this.LtextBox.Size = new System.Drawing.Size(180, 33);
            this.LtextBox.TabIndex = 7;
            // 
            // WtextBox
            // 
            this.WtextBox.Location = new System.Drawing.Point(155, 207);
            this.WtextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.WtextBox.Name = "WtextBox";
            this.WtextBox.Size = new System.Drawing.Size(180, 33);
            this.WtextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "高";
            // 
            // HextBox
            // 
            this.HextBox.Location = new System.Drawing.Point(155, 293);
            this.HextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.HextBox.Name = "HextBox";
            this.HextBox.Size = new System.Drawing.Size(180, 33);
            this.HextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 343);
            this.Controls.Add(this.HextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WtextBox);
            this.Controls.Add(this.LtextBox);
            this.Controls.Add(this.RtextBox);
            this.Controls.Add(this.TrapezoidButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.Circlebutton);
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
        private System.Windows.Forms.Button Circlebutton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button TrapezoidButton;
        private System.Windows.Forms.TextBox RtextBox;
        private System.Windows.Forms.TextBox LtextBox;
        private System.Windows.Forms.TextBox WtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HextBox;
    }
}

