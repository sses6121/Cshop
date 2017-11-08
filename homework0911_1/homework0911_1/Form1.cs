using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0911_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void openBtn_Click(object sender, EventArgs e) {
            string filename = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                filename = openFileDialog1.FileName;
            axWindowsMediaPlayer1.URL = filename;
        }

        private void playBtn_Click(object sender, EventArgs e) {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pauseBtn_Click(object sender, EventArgs e) {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void stopBtn_Click(object sender, EventArgs e) {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
