using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0830_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        int initmoney = 10000;
        int interest = 3;
        private void Form1_Load(object sender, EventArgs e) {
            textBox1.Text = initmoney.ToString();
            textBox2.Text = interest.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            try {
                initmoney=Convert.ToInt32(textBox1.Text);

            } catch {
                MessageBox.Show("本金請輸入數值");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            try {
                interest=Convert.ToInt32(textBox2.Text);
                textBox3.Text = (initmoney * interest / 100).ToString();
            } catch {
                MessageBox.Show("年利率請輸入數值");
            }
        }

        private void Exit_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
    

}
