using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace homework0904_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void StartButton_Click(object sender, EventArgs e) {
            PictureBox[] PicBox = new PictureBox[] { pictureBox1,pictureBox2,pictureBox3,pictureBox4,
                                pictureBox5,pictureBox6};
            int[] ArrGnd = new int[6];
            GndRnd(ArrGnd, 1, 42);
            for(int i = 0; i < ArrGnd.Length; i++) {
                PicBox[i].Image = Image.FromFile(ArrGnd[i] + ".gif");
            }

        }
        private void GndRnd(int[] vArray,int n1,int n2) {
            Random r = new Random();
            for(int i = 0; i < vArray.Length; i++) {
                Thread.Sleep(100);
                vArray[i] = r.Next(n1, n2 + 1);
                Thread.Sleep(50);
            }
        }
    }
}
