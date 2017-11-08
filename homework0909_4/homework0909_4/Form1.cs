using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0909_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            FontDialog fontDialog1 = new FontDialog();
            
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = fontDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e) {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e) {
            richTextBox1.SelectionBullet = true;
        }

        private void button4_Click(object sender, EventArgs e) {
            richTextBox1.SelectionBullet = false;
        }

        private void button5_Click(object sender, EventArgs e) {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "文字檔 (*.rtf)|*.rtf|所有檔案|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.DefaultExt = ".rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                filename = openFileDialog1.FileName;
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
            }
        }
    }
}
