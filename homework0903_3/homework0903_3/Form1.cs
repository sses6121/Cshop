using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0903_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        string httpgoogle = "www.google.com.tw";
        string EmailAdd = "test@gmail.com";
        string calExe = "C:\\Windows\\System32\\calc.exe";

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(httpgoogle);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(EmailAdd);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(calExe);
        }
    }
}
