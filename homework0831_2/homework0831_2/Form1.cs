using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0831_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            ResultLabel.Text = "請輸入年所得後按確定鈕，" + System.Environment.NewLine + "" +
    "電腦會算出繳稅金額!";
        }

        private void OK_Button_Click(object sender, EventArgs e) {
            try {
                decimal x = Convert.ToInt32(textBox1.Text);
                decimal tax = 0;
                if (x < 300000) {
                    tax = 0;
                    FinalTax(x, tax);
                } else if (300000 <= x && x < 600000) {
                    tax = x * 3 / 100;
                    FinalTax(x, tax);
                } else if (600000 <= x && x < 900000) {
                    tax = (x - 600000) * 6 / 100 + 600000 * 3 / 100;
                    FinalTax(x, tax);
                } else if (900000 <= x && x < 1500000) {
                    tax = (x - 900000) * 12 / 100 + (x - 600000) * 6 / 100
                        + 600000 * 3 / 100;
                    FinalTax(x, tax);
                } else if (1500000 <= x && x < 5000000) {
                    tax = (x-1500000)*20/100+(x - 900000) * 12 / 100 + 
                        (x - 600000) * 6 / 100+ 600000 * 3 / 100;
                    FinalTax(x, tax);
                } else {
                    tax =(x- 5000000)*30/100+(x - 1500000) * 20 / 100 + (x - 900000) * 12 / 100 +
                        (x - 600000) * 6 / 100 + 600000 * 3 / 100;
                    FinalTax(x, tax);
                }
                } 
            catch {
                MessageBox.Show("請輸入數字");
            }
        }

        private void FinalTax(decimal x, decimal tax) {
            tax = Convert.ToDecimal(Math.Round(tax,2,MidpointRounding.AwayFromZero));
            ResultLabel.Text = "年所得NT$" + x.ToString() + "元，" +
                System.Environment.NewLine + "應繳所得稅NT$" + tax +"元";
        }
    }
}
