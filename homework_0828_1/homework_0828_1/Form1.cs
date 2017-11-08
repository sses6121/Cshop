using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_0828_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BlackBGButton_Click(object sender, EventArgs e) {
        label1.BackColor = Color.Black;
            }
        private void YellowBGButton_Click(object sender, EventArgs e) {
            label1.BackColor = Color.Yellow;
        }

        private void RedFontButton_Click(object sender, EventArgs e) {
            label1.ForeColor = Color.Red;
        }

        private void BlueFtButton_Click(object sender, EventArgs e) {
            label1.ForeColor = Color.Blue;
        }

        private void BoldButton_Click(object sender, EventArgs e) {

            label1.Font = new Font("新細明體", 48F, FontStyle.Bold);
        }

        private void button6_Click(object sender, EventArgs e) {
            label1.Font = new Font("新細明體", 48F, FontStyle.Italic);
        }
    }
}
