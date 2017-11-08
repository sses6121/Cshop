using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace homework0911_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e) {
            string filename = "";
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            openFile1.FilterIndex = 1;
            openFile1.RestoreDirectory = true;
            openFile1.DefaultExt = ".txt";
            if (openFile1.ShowDialog() == DialogResult.OK) {
                filename = openFile1.FileName;
                FileInfo fileInfo = new FileInfo(filename);
                StreamReader sr = new StreamReader(filename);
                string str = sr.ReadToEnd();
                richTextBox1.AppendText(str + Environment.NewLine);
                sr.Close();
            }
        }

        private void saveFileBtn_Click(object sender, EventArgs e) {
            string filename = "";
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.Filter = "文字檔|*.txt|所有檔案 (*.*)|*.*";
            saveFile1.FilterIndex = 1;
            saveFile1.RestoreDirectory = true;
            saveFile1.DefaultExt = ".txt";
            if (saveFile1.ShowDialog() == DialogResult.OK) {
                filename = saveFile1.FileName;
                FileInfo fileInfo = new FileInfo(filename);
                StreamWriter sw = new StreamWriter(filename);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
