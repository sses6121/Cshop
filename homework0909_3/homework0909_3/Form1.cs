using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0909_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e) {
            FontDialog fontdg = new FontDialog();
            fontdg.ShowColor = true;
            if (fontdg.ShowDialog() == DialogResult.OK)
                label1.Font = fontdg.Font;
                label1.ForeColor = fontdg.Color;
        }

        private void button2_Click(object sender, EventArgs e) {
            ColorDialog colordg = new ColorDialog();
            if (colordg.ShowDialog() == DialogResult.OK)
                label1.BackColor = colordg.Color;
        }

        private void Form1_Load(object sender, EventArgs e) {
            label1.Text = "洪荒之力";
        }
    }
}
