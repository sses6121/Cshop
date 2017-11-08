namespace test0909_2 {
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.第一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第二張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第三張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第四張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(26, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.第一張ToolStripMenuItem,
            this.第二張ToolStripMenuItem,
            this.第三張ToolStripMenuItem,
            this.第四張ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 92);
            // 
            // 第一張ToolStripMenuItem
            // 
            this.第一張ToolStripMenuItem.Name = "第一張ToolStripMenuItem";
            this.第一張ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.第一張ToolStripMenuItem.Text = "第一張";
            this.第一張ToolStripMenuItem.Click += new System.EventHandler(this.第一張ToolStripMenuItem_Click);
            // 
            // 第二張ToolStripMenuItem
            // 
            this.第二張ToolStripMenuItem.Name = "第二張ToolStripMenuItem";
            this.第二張ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.第二張ToolStripMenuItem.Text = "第二張";
            this.第二張ToolStripMenuItem.Click += new System.EventHandler(this.第二張ToolStripMenuItem_Click);
            // 
            // 第三張ToolStripMenuItem
            // 
            this.第三張ToolStripMenuItem.Name = "第三張ToolStripMenuItem";
            this.第三張ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.第三張ToolStripMenuItem.Text = "第三張";
            this.第三張ToolStripMenuItem.Click += new System.EventHandler(this.第三張ToolStripMenuItem_Click);
            // 
            // 第四張ToolStripMenuItem
            // 
            this.第四張ToolStripMenuItem.Name = "第四張ToolStripMenuItem";
            this.第四張ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.第四張ToolStripMenuItem.Text = "第四張";
            this.第四張ToolStripMenuItem.Click += new System.EventHandler(this.第四張ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 389);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "右建切換風景圖";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 第一張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第二張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第三張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第四張ToolStripMenuItem;
    }
}

