using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0831_5 {

    public partial class Form1 : Form {
        int Money;
        int SpendMoney;
        int Result;
        public Form1() {
            InitializeComponent();
        }


        private void CashTextBox_TextChanged(object sender, EventArgs e) {
            try {
                Money = Convert.ToInt32(CashTextBox.Text);
            } catch {
                MessageBox.Show("收現:請輸入數字");
            }
        }
        private void SpendTextBox_TextChanged(object sender, EventArgs e) {
            try {
                SpendMoney = Convert.ToInt32(SpendTextBox.Text);
            } catch {
                MessageBox.Show("消費:請輸入數字");
            }
        }
        private void CalButton_Click(object sender, EventArgs e) {
            if (SpendMoney <= Money) {
                Result = Money - SpendMoney;
                int temp = Result;
                if (temp >= 0) {
                    if (Result >= 1000) {
                        textBox1000.Text = (Result / 1000).ToString();
                        temp = Result % 1000;
                    }
                    if (temp >= 500 && temp < 1000) {
                        textBox500.Text = (temp / 500).ToString();
                        temp = temp % 500;
                    }
                    if (temp >= 100 && temp < 500) {
                        textBox100.Text = (temp / 100).ToString();
                        temp = temp % 100;
                    }
                    if (temp >= 50 && temp < 100) {
                        textBox50.Text = (temp / 50).ToString();
                        temp = temp % 50;
                    }
                    if (temp >= 10 && temp < 50) {
                        textBox10.Text = (temp / 10).ToString();
                        temp = temp % 10;
                    }
                    if (temp >= 5 && temp < 10) {
                        textBox5.Text = (temp / 5).ToString();
                        temp = temp % 5;
                    }
                    if (temp >= 0 && temp < 5) {
                        textBox1.Text = (temp / 1).ToString();
                        temp = temp % 1;
                    }
                    ChagetextBox.Text = Result.ToString();
                }
            } else MessageBox.Show("收現金額不足!請注意!!");
        }
    }
}
