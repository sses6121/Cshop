namespace homework0903_2 {
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
            this.PtNcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PtCostTextBox = new System.Windows.Forms.TextBox();
            this.Pc_CostLabel = new System.Windows.Forms.Label();
            this.Pt_PriceLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.PtPricetextBox = new System.Windows.Forms.TextBox();
            this.Pt_NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PtNcomboBox
            // 
            this.PtNcomboBox.FormattingEnabled = true;
            this.PtNcomboBox.Location = new System.Drawing.Point(15, 128);
            this.PtNcomboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PtNcomboBox.Name = "PtNcomboBox";
            this.PtNcomboBox.Size = new System.Drawing.Size(219, 29);
            this.PtNcomboBox.TabIndex = 0;
            this.PtNcomboBox.SelectedIndexChanged += new System.EventHandler(this.PtNcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "商店進貨管理系統";
            // 
            // PtCostTextBox
            // 
            this.PtCostTextBox.Location = new System.Drawing.Point(269, 134);
            this.PtCostTextBox.Name = "PtCostTextBox";
            this.PtCostTextBox.Size = new System.Drawing.Size(194, 33);
            this.PtCostTextBox.TabIndex = 2;
            // 
            // Pc_CostLabel
            // 
            this.Pc_CostLabel.AutoSize = true;
            this.Pc_CostLabel.Location = new System.Drawing.Point(265, 110);
            this.Pc_CostLabel.Name = "Pc_CostLabel";
            this.Pc_CostLabel.Size = new System.Drawing.Size(52, 21);
            this.Pc_CostLabel.TabIndex = 3;
            this.Pc_CostLabel.Text = "成本";
            // 
            // Pt_PriceLabel
            // 
            this.Pt_PriceLabel.AutoSize = true;
            this.Pt_PriceLabel.Location = new System.Drawing.Point(265, 176);
            this.Pt_PriceLabel.Name = "Pt_PriceLabel";
            this.Pt_PriceLabel.Size = new System.Drawing.Size(52, 21);
            this.Pt_PriceLabel.TabIndex = 4;
            this.Pt_PriceLabel.Text = "售價";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(269, 264);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(142, 31);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "確定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // PtPricetextBox
            // 
            this.PtPricetextBox.Location = new System.Drawing.Point(269, 200);
            this.PtPricetextBox.Name = "PtPricetextBox";
            this.PtPricetextBox.Size = new System.Drawing.Size(194, 33);
            this.PtPricetextBox.TabIndex = 3;
            // 
            // Pt_NameLabel
            // 
            this.Pt_NameLabel.AutoSize = true;
            this.Pt_NameLabel.Location = new System.Drawing.Point(12, 98);
            this.Pt_NameLabel.Name = "Pt_NameLabel";
            this.Pt_NameLabel.Size = new System.Drawing.Size(52, 21);
            this.Pt_NameLabel.TabIndex = 7;
            this.Pt_NameLabel.Text = "品名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 306);
            this.Controls.Add(this.Pt_NameLabel);
            this.Controls.Add(this.PtPricetextBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Pt_PriceLabel);
            this.Controls.Add(this.Pc_CostLabel);
            this.Controls.Add(this.PtCostTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PtNcomboBox);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PtNcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PtCostTextBox;
        private System.Windows.Forms.Label Pc_CostLabel;
        private System.Windows.Forms.Label Pt_PriceLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox PtPricetextBox;
        private System.Windows.Forms.Label Pt_NameLabel;
    }
}

