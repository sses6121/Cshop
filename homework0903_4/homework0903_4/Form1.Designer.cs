namespace homework0903_4 {
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
            this.Rlabel = new System.Windows.Forms.Label();
            this.Glabel = new System.Windows.Forms.Label();
            this.Blabel = new System.Windows.Forms.Label();
            this.RtrackBar = new System.Windows.Forms.TrackBar();
            this.GtrackBar = new System.Windows.Forms.TrackBar();
            this.BLtrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLtrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "label";
            // 
            // Rlabel
            // 
            this.Rlabel.AutoSize = true;
            this.Rlabel.Location = new System.Drawing.Point(12, 220);
            this.Rlabel.Name = "Rlabel";
            this.Rlabel.Size = new System.Drawing.Size(31, 21);
            this.Rlabel.TabIndex = 4;
            this.Rlabel.Text = "紅";
            // 
            // Glabel
            // 
            this.Glabel.AutoSize = true;
            this.Glabel.Location = new System.Drawing.Point(12, 305);
            this.Glabel.Name = "Glabel";
            this.Glabel.Size = new System.Drawing.Size(31, 21);
            this.Glabel.TabIndex = 5;
            this.Glabel.Text = "綠";
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Location = new System.Drawing.Point(12, 374);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(31, 21);
            this.Blabel.TabIndex = 6;
            this.Blabel.Text = "藍";
            // 
            // RtrackBar
            // 
            this.RtrackBar.Location = new System.Drawing.Point(99, 220);
            this.RtrackBar.Maximum = 255;
            this.RtrackBar.Name = "RtrackBar";
            this.RtrackBar.Size = new System.Drawing.Size(384, 45);
            this.RtrackBar.TabIndex = 7;
            this.RtrackBar.Scroll += new System.EventHandler(this.RtrackBar_Scroll);
            // 
            // GtrackBar
            // 
            this.GtrackBar.Location = new System.Drawing.Point(99, 305);
            this.GtrackBar.Maximum = 255;
            this.GtrackBar.Name = "GtrackBar";
            this.GtrackBar.Size = new System.Drawing.Size(384, 45);
            this.GtrackBar.TabIndex = 8;
            this.GtrackBar.Scroll += new System.EventHandler(this.GtrackBar_Scroll);
            // 
            // BLtrackBar
            // 
            this.BLtrackBar.Location = new System.Drawing.Point(99, 374);
            this.BLtrackBar.Maximum = 255;
            this.BLtrackBar.Name = "BLtrackBar";
            this.BLtrackBar.Size = new System.Drawing.Size(384, 45);
            this.BLtrackBar.TabIndex = 9;
            this.BLtrackBar.Scroll += new System.EventHandler(this.BLtrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 417);
            this.Controls.Add(this.BLtrackBar);
            this.Controls.Add(this.GtrackBar);
            this.Controls.Add(this.RtrackBar);
            this.Controls.Add(this.Blabel);
            this.Controls.Add(this.Glabel);
            this.Controls.Add(this.Rlabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLtrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Rlabel;
        private System.Windows.Forms.Label Glabel;
        private System.Windows.Forms.Label Blabel;
        private System.Windows.Forms.TrackBar RtrackBar;
        private System.Windows.Forms.TrackBar GtrackBar;
        private System.Windows.Forms.TrackBar BLtrackBar;
    }
}

