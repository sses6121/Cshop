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

namespace HW_Teams {
    public partial class Form1 : Form {
        private bool EndOfStream;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Directory.CreateDirectory(@"D:\temp");
            Encoding encoder = Encoding.GetEncoding("Big5");
            StreamWriter sw = new StreamWriter(@"D:\temp\teams.txt", false, encoder);
            sw.WriteLine("洋基隊    NYY");
            sw.WriteLine("釀酒人隊  MIL");
            sw.Close();
        }
        string chineseS = "";
        string engS = "";
        private void button1_Click(object sender, EventArgs e) {
            Encoding encoder = Encoding.GetEncoding("Big5");
            StreamReader sr = new StreamReader(@"D:\Temp\teams.txt", encoder);
            string[] chineseString = new string[13];
            int count = 0;
            while (!sr.EndOfStream) {
                //try { 
                string line = sr.ReadLine();
                string temp = line;
                int kk = 0;
                line = temp.Replace(" ", "");
                byte[] lineByte = encoder.GetBytes(line);
                string[] chinesestring = new string[lineByte.Length];
                string[] engstring = new string[lineByte.Length];

                byte[] chineseByte = new byte[lineByte.Length];
                byte[] engByte = new byte[lineByte.Length];
                char[] chinesechar = new char[lineByte.Length];
                char[] engchar = new char[lineByte.Length];
                //byte[] chineseByte;
                //byte[] engByte;
                
                string aaatemp = "";
                for (int i = 0; i < lineByte.Length; i += 1) {

                    if (lineByte[i] >= 128) {
                        chineseByte[i] = lineByte[i];
                        chineseByte[i + 1] = lineByte[i + 1];
                        chineseByte[i + 2] = lineByte[i + 2];
                        chinesestring[i] = encoder.GetString(chineseByte, i, 2);
                        i += 1;
                        count += 1;
                    } else if (lineByte[i] < 128) {

                        //engS = encoder.GetString(lineByte,count,)
                        engByte[i] = lineByte[i];
                        //engchar = Encoding.UTF8.GetChars(engByte, i, 1);
                        string aaa = Encoding.UTF8.GetString(engByte, i, 1);
                        aaatemp += aaa;
                        //engstring +=
                        //MessageBox.Show(aaatemp);
                    }


                    /* for (int j = 0; j < count; j++) {
                         if (chinesestring[j] != null)
                             chineseS += chinesestring[j];
                     }
                     listBox1.Items.Add(chineseS);
                 }*/

                   

                }
                for (int j = 0; j < chinesestring.Length; j++) {
                    if (chinesestring[j] != null)
                        chineseS += chinesestring[j];
                }
            }
            sr.Close();
            textBox1.Text = chineseS.Substring(0, 3) + System.Environment.NewLine + chineseS.Substring(3,4);
            listBox1.Items.Add(chineseS.Substring(0, 3));
            listBox1.Items.Add(chineseS.Substring(3, 4));
        }


        private void button2_Click(object sender, EventArgs e) {
            Encoding encoder = Encoding.GetEncoding("Big5");
            StreamReader sr = new StreamReader(@"D:\Temp\teams.txt", encoder);
            string[] chineseString = new string[13];
            int count = 0;
            string [] engString = new string[13];
            while (!sr.EndOfStream) {
                //try { 
                string line = sr.ReadLine();
                string temp = line;
                int kk = 0;
                line = temp.Replace(" ", "");
                byte[] lineByte = encoder.GetBytes(line);
                string[] chinesestring = new string[lineByte.Length];
                string[] engstring = new string[lineByte.Length];

                byte[] chineseByte = new byte[lineByte.Length];
                byte[] engByte = new byte[lineByte.Length];
                char[] chinesechar = new char[lineByte.Length];
                char[] engchar = new char[lineByte.Length];
                //byte[] chineseByte;
                //byte[] engByte;

                string aaatemp = "";
                for (int i = 0; i < lineByte.Length; i += 1) {

                    if (lineByte[i] >= 128) {
                        chineseByte[i] = lineByte[i];
                        chineseByte[i + 1] = lineByte[i + 1];
                        chineseByte[i + 2] = lineByte[i + 2];
                        chinesestring[i] = encoder.GetString(chineseByte, i, 2);
                        i += 1;
                        count += 1;
                    } else if (lineByte[i] < 128) {

                        //engS = encoder.GetString(lineByte,count,)
                        engByte[i] = lineByte[i];
                        //engchar = Encoding.UTF8.GetChars(engByte, i, 1);
                        engstring[i] = Encoding.UTF8.GetString(engByte, i, 1);
                        //aaatemp += aaa;
                        //engstring +=
                        //MessageBox.Show(aaatemp);
                        //engString[i] = aaatemp;
                    }

                   // MessageBox.Show(aaatemp);
                    /* for (int j = 0; j < count; j++) {
                         if (chinesestring[j] != null)
                             chineseS += chinesestring[j];
                     }
                     listBox1.Items.Add(chineseS);
                 }*/



                }
                for (int j = 0; j < engstring.Length; j++) {
                    if (engstring[j] != null)
                        engS += engstring[j];
                   // MessageBox.Show(engstring[j]);
                }
            }
            sr.Close();
            textBox1.Text = engS.Substring(0,3) +  System.Environment.NewLine + engS.Substring(3,3);
            listBox1.Items.Add(engS.Substring(0, 3));
            listBox1.Items.Add(engS.Substring(3, 3));
        }
    }
        }
