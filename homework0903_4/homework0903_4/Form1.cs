using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0903_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        int red = 0;
        int green = 0;
        int blue = 0;
        private void RtrackBar_Scroll(object sender, EventArgs e) {
            red = RtrackBar.Value;
            label1.ForeColor = Color.FromArgb(255-red, 255-green, 255-blue);
            label1.BackColor = Color.FromArgb(red, green, blue);
            label1.Text = string.Format("紅={0} 綠={1} 藍={2}",red,green,blue);
        }

        private void GtrackBar_Scroll(object sender, EventArgs e) {
            green = GtrackBar.Value;
            label1.ForeColor = Color.FromArgb(255 - red, 255 - green, 255 - blue);
            label1.BackColor = Color.FromArgb(red, green, blue);
            label1.Text = string.Format("紅={0} 綠={1} 藍={2}", red, green, blue);
        }

        private void BLtrackBar_Scroll(object sender, EventArgs e) {
            blue = BLtrackBar.Value;
            label1.ForeColor = Color.FromArgb(255 - red, 255 - green, 255 - blue);
            label1.BackColor = Color.FromArgb(red, green, blue);
            label1.Text = string.Format("紅={0} 綠={1} 藍={2}", red, green, blue);
        }
    }
}
