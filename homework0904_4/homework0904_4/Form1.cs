using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0904_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        bool drag = true;
        private void Form1_Load(object sender, EventArgs e) {
            //textBox1.Focus();
            //textBox1.GotFocus();
        }
        private void OnFocus(object sender, EventArgs e) {
          //  MessageBox.Show("OK");
        }
        private void GotFocus(object sender,EventArgs e) {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if (textBox1.Focus()) {
                textBox1.Enabled = true;
                switch (e.KeyCode) {
                    case Keys.Right:
                        int X = textBox1.Location.X + 10;
                        int Y = textBox1.Location.Y;
                        textBox1.Location = new Point(X, Y);
                        break;
                    case Keys.Left:
                        X = textBox1.Location.X - 10;
                        Y = textBox1.Location.Y;
                        textBox1.Location = new Point(X, Y);
                        break;
                    case Keys.Down:
                        X = textBox1.Location.X;
                        Y = textBox1.Location.Y + 10;
                        textBox1.Location = new Point(X, Y);
                        break;
                    case Keys.Up:
                        X = textBox1.Location.X;
                        Y = textBox1.Location.Y - 10;
                        textBox1.Location = new Point(X, Y);
                        break;
                }
            } else if (!textBox1.Focus()) {
                textBox1.Enabled = false;
                int X = textBox1.Location.X;
                int Y = textBox1.Location.Y;
                textBox1.Location = new Point(X, Y);
            }

        }
    }
}
