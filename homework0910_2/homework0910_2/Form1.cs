using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace homework0910_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        string filename;
        SoundPlayer player = new SoundPlayer();
        private void OpenFileBtn_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = ".wav";
            openFileDialog1.Filter = "音效檔(*.wav)|*.wav|所有檔案(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                filename = openFileDialog1.FileName;
                player.SoundLocation = filename;
                player.Load();
            }

        }

        private void playFileBtn_Click(object sender, EventArgs e) {
            player.Play();
        }

        private void repeatBtn_Click(object sender, EventArgs e) {
            player.PlayLooping();
        }

        private void stopBtn_Click(object sender, EventArgs e) {
            player.Stop();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
