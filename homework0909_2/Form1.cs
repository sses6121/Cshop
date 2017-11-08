using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0909_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        int [] img = new int[4] {1,2,3,4};
        private void 第一張ToolStripMenuItem_Click(object sender, EventArgs e) {
            pictureBox1.Image = Image.FromFile("img" + img[0] + ".jpg");
            
        }

        private void 第二張ToolStripMenuItem_Click(object sender, EventArgs e) {
            pictureBox1.Image = Image.FromFile("img" + img[1] + ".jpg");
        }

        private void 第三張ToolStripMenuItem_Click(object sender, EventArgs e) {
            pictureBox1.Image = Image.FromFile("img" + img[2] + ".jpg");
        }

        private void 第四張ToolStripMenuItem_Click(object sender, EventArgs e) {
            pictureBox1.Image = Image.FromFile("img" + img[3] + ".jpg");
        }

        private void Form1_Load(object sender, EventArgs e) {
            pictureBox1.Image = Image.FromFile("img" + img[0] + ".jpg");
        }
    }
}
