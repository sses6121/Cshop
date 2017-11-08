using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0904_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private double GetArea(double r) {
            return Math.PI * Math.Pow(r, 2);
        }
        private int GetArea(int l,int w) {
            return l * w;
        }
        private int GetArea(int l,int w,int h) {
            return (l + w) * h / 2;
        }
        private void Circlebutton_Click(object sender, EventArgs e) {
            try {
                double r = Convert.ToDouble(RtextBox.Text);
                double Result = Math.Round(GetArea(r),2,MidpointRounding.AwayFromZero);
                string Rs = Result.ToString();
                
                MessageBox.Show("半徑為" + r + "的圓形面積為" + Result);
            } catch {
                MessageBox.Show("半徑請輸入數字");

            }
        }

            private void RectangleButton_Click(object sender, EventArgs e) {
                try {
                    int l = Convert.ToInt32(LtextBox.Text);
                    int w = Convert.ToInt32(WtextBox.Text);
                    double Result = GetArea(l, w);
                    MessageBox.Show("長為" + l + ",寬為" + w, "的長方形面積為" + Result);
                } catch {
                    MessageBox.Show("長、寬請輸入數字");
                }

            }

            private void TrapezoidButton_Click(object sender, EventArgs e) {
                try {
                    int up = Convert.ToInt32(LtextBox.Text);
                    int buttom = Convert.ToInt32(WtextBox.Text);
                    int h = Convert.ToInt32(HextBox.Text);
                    double Result = GetArea(up, buttom, h);
                    MessageBox.Show("上底為" + up + ",下底為" + buttom + ",高為" + h + "的梯形面積為" + Result);
                } catch {
                    MessageBox.Show("'上底、下底、高請輸入數字");
                }

            }
        }
}
