using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0905_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            MessageBox.Show(Form1.MouseButtons.ToString());
        }


        private void Form1_Load(object sender, EventArgs e) {
            pictureBox1.Image = Image.FromFile("TRFFC10A.ICO");
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) {
            switch (e.Button) {
                case MouseButtons.Left:
                case MouseButtons.Middle:
                    pictureBox1.Image = Image.FromFile("TRFFC10C.ICO");
                    break;
                case MouseButtons.Right:
                    pictureBox1.Image = Image.FromFile("TRFFC10B.ICO");
                    break;
                case MouseButtons.None:
                    pictureBox1.Image = Image.FromFile("TRFFC10A.ICO");
                    break;
                default:
                    pictureBox1.Image = Image.FromFile("TRFFC10A.ICO");
                    break;

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) {
            pictureBox1.Image = Image.FromFile("TRFFC10A.ICO");
        }
    }
}
