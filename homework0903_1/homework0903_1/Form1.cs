using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0903_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        string[] PtItem = new string[] {"舒跑","黑松汽水","多喝水","多果汁","青箭口香糖","王子麵","聯合報" };
        int[] PtPrice = new int[] { 25, 24, 20, 13, 10, 10, 10 };
        int [] PtNumber = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        int [] sum = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        int total = 0;
        int PtIndex = 0;


        private void Form1_Load(object sender, EventArgs e) {
            for(int i = 0; i < PtItem.Length; i++)
                listBox1.Items.Add(PtItem[i]);
            Pt_Name.Enabled = false;
            Pt_Price.Enabled = false;
            Pt_Count.Enabled = false;
            TotalPrice.Enabled = false;
        }

        private void OKButton_Click(object sender, EventArgs e) {
            try {
                PtNumber[PtIndex] = Convert.ToInt32(Pt_Number.Text);
                total = 0;
                sum[PtIndex] = PtPrice[PtIndex] * PtNumber[PtIndex];
                Pt_Count.Text = sum[PtIndex].ToString();
                for (int i = 0; i < PtPrice.Length; i++)
                    total += sum[i];
                TotalPrice.Text = total.ToString();
            } catch {
                MessageBox.Show("數量請輸入數字", "錯誤", MessageBoxButtons.OK);
            }           
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            PtNumber = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            sum = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            total = 0;
            Pt_Number.Text = "";
            Pt_Count.Text = "";
            TotalPrice.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            PtIndex = listBox1.SelectedIndex;
            Pt_Name.Text = PtItem[PtIndex];
            Pt_Price.Text = PtPrice[PtIndex].ToString();            
        }
    }
}
