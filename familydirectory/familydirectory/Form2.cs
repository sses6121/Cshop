using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace familydirectory {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();

        }
        public string familyName = "";
        public string familyCellPhone = "";
        public string familyAddress = "";
        public string familyAppel = "";
        private void OKBtn_Click(object sender, EventArgs e) {
            Form1 form1 = (Form1)Owner;
            form1.Select();
            form1.familyName = NameTxtBox.Text;
            form1.familyCellPhone = CellTxtBox.Text;
            form1.familyAddress = AddTextBox.Text;
            form1.familyAppel = textBox1.Text;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e) {
            Form1 form1 = (Form1)Owner;
            form1.Select();
            if (!form1.input) { 
            NameTxtBox.Text=form1.familyName;
            CellTxtBox.Text= form1.familyCellPhone;
            AddTextBox.Text=form1.familyAddress;
            textBox1.Text=form1.familyAppel;
            } else {
                NameTxtBox.Text = "";
                CellTxtBox.Text = "";
                AddTextBox.Text = "";
                textBox1.Text = "";
            }
        }
    }
}
