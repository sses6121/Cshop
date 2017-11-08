using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0831_04 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e) {
            try {
                int x = 0;
                int sum = 0;
                x = Convert.ToInt32(textBox1.Text);
                if (x >= 7 && x < 100) {
                    string s = "1到" + x + "被7整除的數:" + System.Environment.NewLine;
                    for (int i = 1; i <= x; i++) {
                        if (i % 7 == 0) {
                            s += i + System.Environment.NewLine;
                            sum += i;
                        }

                    }
                    s += "------------------" + System.Environment.NewLine;
                    s += "總和等於" + sum;
                    MessageBox.Show(s);
                } else MessageBox.Show("請輸入大於7小於100的正整數", "錯誤");
            } catch {
                MessageBox.Show("請輸入數字", "錯誤");
            }
        }
    }
}
