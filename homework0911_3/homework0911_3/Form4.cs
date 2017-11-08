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
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        int x = 0;
        int y = 0;
        private void addBtn_Click(object sender, EventArgs e) {
            textBox1.Text = x.ToString() + " + " + y.ToString() + " = " + (x + y).ToString();
        }

        private void subBtn_Click(object sender, EventArgs e) {
            textBox2.Text = x.ToString() + " - " + y.ToString() + " = " + (x - y).ToString();
        }

        private void multiBtn_Click(object sender, EventArgs e) {
            textBox3.Text = x.ToString() + " * " + y.ToString() + " = " + (x * y).ToString();
        }

        private void divisionBtn_Click(object sender, EventArgs e) {
            textBox4.Text = x.ToString() + " / " + y.ToString() + " = " + (x / y).ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void Form4_Load(object sender, EventArgs e) {
            label1.Text += " " + x.ToString();
            label2.Text += " " + y.ToString();
        }

        public int SetX(int a) {
            x = a;
            return x;
        }
        public int SetY(int a) {
            y = a;
            return y;
        }
    }
}
