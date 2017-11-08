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

namespace homework0910_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        string[] chiFruit = new string[] { "橘子", "鳳梨", "番茄", "草莓", "蘋果", "香蕉", "西瓜", "梨子" };
        string[] engFruit = new string[] { "orange", "pineapple", "tomato", "strawberry", "apple", "banana", "watermelon", "pear" };
        string fname = "";
        SoundPlayer player = new SoundPlayer();

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e) {
            pictureBox1.Image = Image.FromFile(@"image\FRUIT1.BMP");
            pictureBox2.Image = Image.FromFile(@"image\FRUIT2.BMP");
            pictureBox3.Image = Image.FromFile(@"image\FRUIT3.BMP");
            pictureBox4.Image = Image.FromFile(@"image\FRUIT4.BMP");
            pictureBox5.Image = Image.FromFile(@"image\FRUIT5.BMP");
            pictureBox6.Image = Image.FromFile(@"image\FRUIT6.BMP");
            pictureBox7.Image = Image.FromFile(@"image\FRUIT7.BMP");
            pictureBox8.Image = Image.FromFile(@"image\FRUIT8.BMP");
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            fname = @"sound\FRUIT1.WAV";
            player.SoundLocation = fname;
            player.Play();
            chineseTxtBox.Text = chiFruit[0];
            engTxtBox.Text = engFruit[0];
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            fname = @"sound\FRUIT2.WAV";
            player.SoundLocation = fname;
            player.Play();
            chineseTxtBox.Text = chiFruit[1];
            engTxtBox.Text = engFruit[1];
        }

        private void pictureBox3_Click(object sender, EventArgs e) {
            fname = @"sound\FRUIT3.WAV";
            player.SoundLocation = fname;
            player.Play();
            chineseTxtBox.Text = chiFruit[2];
            engTxtBox.Text = engFruit[2];
        }

        private void pictureBox4_Click(object sender, EventArgs e) {
            fname = @"sound\FRUIT4.WAV";
            player.SoundLocation = fname;
            player.Play();
            chineseTxtBox.Text = chiFruit[3];
            engTxtBox.Text = engFruit[3];
        }

        private void pictureBox5_Click(object sender, EventArgs e) {
            fname = @"sound\FRUIT5.WAV";
            player.SoundLocation = fname;
            player.Play();
            chineseTxtBox.Text = chiFruit[4];
            engTxtBox.Text = engFruit[4];
        }

        private void pictureBox6_Click(object sender, EventArgs e) {
            fname = @"sound\FRUIT6.WAV";
            player.SoundLocation = fname;
            player.Play();
            chineseTxtBox.Text = chiFruit[5];
            engTxtBox.Text = engFruit[5];
        }

        private void pictureBox7_Click(object sender, EventArgs e) {
            fname = @"sound\FRUIT7.WAV";
            player.SoundLocation = fname;
            player.Play();
            chineseTxtBox.Text = chiFruit[6];
            engTxtBox.Text = engFruit[6];
        }

        private void pictureBox8_Click(object sender, EventArgs e) {
            fname = @"sound\FRUIT8.WAV";
            player.SoundLocation = fname;
            player.Play();
            chineseTxtBox.Text = chiFruit[7];
            engTxtBox.Text = engFruit[7];
        }
    }
}
