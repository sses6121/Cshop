using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0904_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        int[] ResultArr = new int[4] { 0, 0, 0, 0 };

        int i = 0;
        private void Form1_Load(object sender, EventArgs e) {
        }

        private void ResultButton_Click(object sender, EventArgs e) {
            Random r0 = new Random();
            i = r0.Next(0, 10);
            PictureBox[] PicBox = new PictureBox[4] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            for (int j = 0; j < ResultArr.Length; j++) {
                ResultArr[j] = i;
                Thread.Sleep(100);
                i = r0.Next(0, 10);
                ResultArr[j] = i;
                Thread.Sleep(50);
                PicBox[j].Image = Image.FromFile(ResultArr[j].ToString() + ".gif");

            }
        }
    }
}
