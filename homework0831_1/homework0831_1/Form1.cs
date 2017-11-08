using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0831_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            ResultLabel.Text = "請輸入數字後按確定鈕，"+System.Environment.NewLine+"" +
                "電腦會判斷是奇數還是偶數!";
        }
        
        private void OK_Click(object sender, EventArgs e) {
            try {
                int x= Convert.ToInt32(textBox1.Text);
                switch(x%2) {
                    case 0:
                        ResultLabel.Text = x.ToString() + "是偶數";
                        break;
                    case 1:
                        ResultLabel.Text = x.ToString() + "是奇數";
                        break;
                }
            } 
            catch {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
