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

namespace homework0910_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            string sourceDir = @"c:\work";
            FileInfo flinfo = new FileInfo(sourceDir + "\\text3.txt");
            StreamReader sr = new StreamReader(sourceDir + "\\text1.txt");
            string str = sr.ReadToEnd();
            sr.Close();
            StreamReader sr1 = new StreamReader(sourceDir + "\\text2.txt");
            string str1 = sr1.ReadToEnd();
            sr1.Close();
            StreamWriter sw = flinfo.CreateText();

            sw.Write(str + Environment.NewLine);
            sw.Close();
            StreamWriter sw1 = flinfo.AppendText();
            sw1.Write(Environment.NewLine + str1);
            sw1.Close();




        }
    }
}
