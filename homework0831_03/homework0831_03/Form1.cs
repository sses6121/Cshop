using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0831_03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //private decimal checkTestBox(NTD,NTDUS) {
            //try {
             //   decimal NTD = Convert.ToDecimal(NTDtextBox.Text);
              //  decimal NTDUS = Convert.ToDecimal(NTDtextBox.Text);

            //} catch {
             //   MessageBox.Show("請確認金額或匯率是否為數字");
           // }
          //  return NTD;
       // }

        private void NTDUSRadioButton_CheckedChanged(object sender, EventArgs e) {
            try {
                double Dollar = Convert.ToDouble(NTDtextBox.Text);
                double NTDUS = Convert.ToDouble(NTDUStextBox.Text);
                double Result = Math.Round(Dollar / NTDUS,2,MidpointRounding.AwayFromZero);
                label3.Text= "台幣"+Dollar+"元可換成美金"+ Result+"元";

            } catch {
                MessageBox.Show("請確認金額或匯率是否為數字");
            }
            

        }



        private void USNTDRadioButton_CheckedChanged(object sender, EventArgs e) {
            try {
                double Dollar = Convert.ToDouble(NTDtextBox.Text);
                double NTDUS = Convert.ToDouble(NTDUStextBox.Text);
                double Result = Math.Round(Dollar * NTDUS,2,MidpointRounding.AwayFromZero);
                label3.Text = "美金" + Dollar + "元可換成台幣" + Result + "元";

            } catch {
                MessageBox.Show("請確認金額或匯率是否為數字");
            }
        }
    }
}
