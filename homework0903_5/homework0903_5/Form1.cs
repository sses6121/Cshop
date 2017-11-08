using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0903_5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        int Date_Month = 0;
        private void Form1_Load(object sender, EventArgs e) {
            Date_Month = DateTime.Now.Month;
            MonthPic(Date_Month);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {
            Date_Month = monthCalendar1.SelectionStart.Month;
            MonthPic(Date_Month);
        }

        private void MonthPic(int Date_Month) {
            switch (Date_Month) {
                case 2:
                case 3:
                case 4:
                    PicShow.Image = Image.FromFile("春.jpg");
                    break;
                case 5:
                case 6:
                case 7:
                    PicShow.Image = Image.FromFile("夏.jpg");
                    break;
                case 8:
                case 9:
                case 10:
                    PicShow.Image = Image.FromFile("秋.jpg");
                    break;
                case 11:
                case 12:
                case 1:
                    PicShow.Image = Image.FromFile("冬.jpg");
                    break;
            }
        }
    }
}
