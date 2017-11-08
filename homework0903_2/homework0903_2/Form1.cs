using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0903_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        string[] PtItem = new string[] { "舒跑", "黑松汽水", "多喝水", "多果汁", "青箭口香糖", "王子麵", "聯合報" };
        int[] PtPrice = new int[] { 25, 18, 20, 13, 10, 10, 10 };
        int[] PtCost = new int[] { 20, 12, 10, 8, 5, 5, 7 };
        int PtIndex = 0;



        private void Form1_Load(object sender, EventArgs e) {
            for (int i = 0; i < PtItem.Length; i++)
                PtNcomboBox.Items.Add(PtItem[i]);
        }

        private void OKButton_Click(object sender, EventArgs e) {
            if (!PtItem.Contains(PtNcomboBox.Text)) {
                string[] PtItemTemp = PtItem;
                int[] PtCostTemp = PtCost;
                int[] PtPriceTemp = PtPrice;
                Array.Resize(ref PtItem, PtItem.Length + 1);
                Array.Resize(ref PtPrice, PtPrice.Length + 1);
                Array.Resize(ref PtCost, PtCost.Length + 1);
                Array.Copy(PtItemTemp, PtItem, PtItemTemp.Length);
                Array.Copy(PtCostTemp, PtCost, PtCostTemp.Length);
                Array.Copy(PtPriceTemp, PtPrice, PtPriceTemp.Length);

                try {
                    PtCost[PtItemTemp.Length] = Convert.ToInt32(PtCostTextBox.Text);
                    PtPrice[PtItemTemp.Length] = Convert.ToInt32(PtPricetextBox.Text);
                    PtItem[PtItemTemp.Length] = PtNcomboBox.Text;
                    MessageBox.Show("新增資料成功", "注意", MessageBoxButtons.OK);
                    PtNcomboBox.Items.Clear();
                    for (int i = 0; i < PtItem.Length; i++)
                        PtNcomboBox.Items.Add(PtItem[i]);

                } catch {
                    MessageBox.Show("請完整輸入品名、成本和售價", "注意", MessageBoxButtons.OK);
                }

            } else {
                try {
                    PtCost[PtIndex] = Convert.ToInt32(PtCostTextBox.Text);
                    PtPrice[PtIndex] = Convert.ToInt32(PtPricetextBox.Text);
                    MessageBox.Show("成本和售價修改成功", "注意", MessageBoxButtons.OK);
                } catch {
                    MessageBox.Show("請完整輸入品名、成本和售價", "注意", MessageBoxButtons.OK);
                }
            }
        }

        private void PtNcomboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (PtItem.Contains(PtNcomboBox.Text)) {
                PtIndex = PtNcomboBox.SelectedIndex;
                PtCostTextBox.Text = PtCost[PtIndex].ToString();
                PtPricetextBox.Text = PtPrice[PtIndex].ToString();
            }
        }
    }
}
