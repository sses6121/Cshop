using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0911_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        int a = 0;
        int b = 0;
        private void button3_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            a = frm2.SetA();
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            b = frm3.SetB();
        }

        private void button2_Click(object sender, EventArgs e) {
            Form4 frm4 = new Form4();
            frm4.SetX(a);
            frm4.SetY(b);
            frm4.ShowDialog();
        }
    }
}
