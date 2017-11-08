namespace homework0903_1 {
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.Pt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pt_Price = new System.Windows.Forms.TextBox();
            this.Pt_Number = new System.Windows.Forms.TextBox();
            this.Pt_Count = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(314, 488);
            this.OKButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(138, 39);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "確定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(476, 488);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(138, 39);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "清除";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(15, 133);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 340);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Titlelabel.Location = new System.Drawing.Point(187, 48);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(308, 48);
            this.Titlelabel.TabIndex = 3;
            this.Titlelabel.Text = "商店結帳系統";
            // 
            // Pt_Name
            // 
            this.Pt_Name.Location = new System.Drawing.Point(432, 149);
            this.Pt_Name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Pt_Name.Name = "Pt_Name";
            this.Pt_Name.Size = new System.Drawing.Size(259, 33);
            this.Pt_Name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "品名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "單價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "數量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 348);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "小計";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 423);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "總計";
            // 
            // Pt_Price
            // 
            this.Pt_Price.Location = new System.Drawing.Point(432, 218);
            this.Pt_Price.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Pt_Price.Name = "Pt_Price";
            this.Pt_Price.Size = new System.Drawing.Size(259, 33);
            this.Pt_Price.TabIndex = 10;
            // 
            // Pt_Number
            // 
            this.Pt_Number.Location = new System.Drawing.Point(432, 281);
            this.Pt_Number.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Pt_Number.Name = "Pt_Number";
            this.Pt_Number.Size = new System.Drawing.Size(259, 33);
            this.Pt_Number.TabIndex = 11;
            // 
            // Pt_Count
            // 
            this.Pt_Count.Location = new System.Drawing.Point(432, 336);
            this.Pt_Count.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Pt_Count.Name = "Pt_Count";
            this.Pt_Count.Size = new System.Drawing.Size(259, 33);
            this.Pt_Count.TabIndex = 12;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Location = new System.Drawing.Point(432, 411);
            this.TotalPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(259, 33);
            this.TotalPrice.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 537);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.Pt_Count);
            this.Controls.Add(this.Pt_Number);
            this.Controls.Add(this.Pt_Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pt_Name);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.TextBox Pt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pt_Price;
        private System.Windows.Forms.TextBox Pt_Number;
        private System.Windows.Forms.TextBox Pt_Count;
        private System.Windows.Forms.TextBox TotalPrice;
    }
}

