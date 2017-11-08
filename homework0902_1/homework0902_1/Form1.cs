using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0902_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        string[] FarmItems = new string[] { "青菜", "山羊", "野狼", "農夫" };
        string[] FarmFood = new string[] { "山羊吃掉青菜", "野狼吃掉山羊" };

        private void ExplainButton_Click(object sender, EventArgs e) {
            string s = "1.農夫1次只能帶1樣或空手過河。" + System.Environment.NewLine +
                       "2.農夫不再時山羊會吃掉青菜，野狼會吃山羊。" + System.Environment.NewLine +
                       "3.3件都帶過河就算過關。";
            MessageBox.Show(s, "遊戲說明", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e) {

            for (int i = 0; i < FarmItems.Length; i++) {
                listBox1.Items.Add(FarmItems[i]);
            }
            RightToLButton.Enabled = false;
        }

        private void LeftToRButton_Click(object sender, EventArgs e) {
            try {
                if (listBox1.Items.Count > 0 && (listBox1.Items.Contains(FarmItems[3]) && listBox1.SelectedItems.Count <= 2)) {
                    string s = listBox1.SelectedItem.ToString();
                    if (s != FarmItems[3]) {
                        listBox2.Items.Add(s);
                        listBox2.Items.Add(FarmItems[3]);
                        listBox1.Items.Remove(FarmItems[3]);
                        listBox1.Items.Remove(s);
                        if (listBox2.Items.Count > 0) {
                            RightToLButton.Enabled = true;
                            LeftToRButton.Enabled = false;
                            listBox1.Enabled = false;
                            listBox2.Enabled = true;
                        }
                    } else {
                        listBox2.Items.Add(s);
                        listBox1.Items.Remove(s);
                        if (listBox2.Items.Count > 0) RightToLButton.Enabled = true;
                        LeftToRButton.Enabled = false;
                        listBox1.Enabled = false;
                        listBox2.Enabled = true;
                    }
                    if (!listBox1.Items.Contains(FarmItems[3])) {
                        if (listBox1.Items.Contains(FarmItems[0]) && listBox1.Items.Contains(FarmItems[1])) {
                            MessageBox.Show(FarmFood[0], "遊戲失敗", MessageBoxButtons.OK);
                            this.Close();
                        } else if (listBox1.Items.Contains(FarmItems[1]) && listBox1.Items.Contains(FarmItems[2])) {
                            MessageBox.Show(FarmFood[1], "遊戲失敗", MessageBoxButtons.OK);
                            this.Close();
                        }
                    }
                } else if (listBox1.Items.Contains(FarmItems[3]) && listBox1.SelectedItems.Count > 2)
                    MessageBox.Show("農夫只能帶一件物品過河" + System.Environment.NewLine + "或空手過河");
                if (listBox1.Items.Count == 0)
                    LeftToRButton.Enabled = false;
                if (listBox1.Items.Count == 0 && listBox2.Items.Count > 0) MessageBox.Show("任務完成");
            } catch {
                MessageBox.Show("請選擇左邊項目，再點按鈕", "錯誤");
            }
        }



        private void RightToLButton_Click(object sender, EventArgs e) {
            if (listBox1.Items.Count == 0 && listBox2.Items.Count == 6) MessageBox.Show("任務完成");
            if (listBox2.Items.Count > 0) RightToLButton.Enabled = true;
            try {
                if (listBox2.Items.Count > 0 && listBox2.Items.Contains(FarmItems[3]) && listBox1.SelectedItems.Count <= 2) {
                    string s = listBox2.SelectedItem.ToString();
                    if (s != FarmItems[3]) {
                        listBox1.Items.Add(s);
                        listBox1.Items.Add(FarmItems[3]);
                        listBox2.Items.Remove(FarmItems[3]);
                        listBox2.Items.Remove(s);
                        listBox2.Enabled = false;
                        listBox1.Enabled = true;
                    } else {
                        listBox1.Items.Add(s);
                        listBox2.Items.Remove(s);
                        listBox2.Enabled = false;
                        listBox1.Enabled = true;
                    }
                    if (!listBox2.Items.Contains(FarmItems[3])) {
                        if (listBox2.Items.Contains(FarmItems[0]) && listBox2.Items.Contains(FarmItems[1])) {
                            MessageBox.Show(FarmFood[0], "遊戲失敗", MessageBoxButtons.OK);
                            this.Close();
                        } else if (listBox2.Items.Contains(FarmItems[1]) && listBox2.Items.Contains(FarmItems[2])) {
                            MessageBox.Show(FarmFood[1], "遊戲失敗", MessageBoxButtons.OK);
                            this.Close();
                        }
                    }
                    if (listBox1.Items.Count > 0) LeftToRButton.Enabled = true;
                    else if (!listBox1.Items.Contains(FarmItems[3]) && listBox2.SelectedItems.Count > 2)
                        MessageBox.Show("農夫只能帶一件物品過河" + System.Environment.NewLine + "或空手過河");
                }
                if (listBox2.Items.Count == 0)
                    RightToLButton.Enabled = false;
            } catch {
                MessageBox.Show("請選擇右邊項目，再點按鈕", "錯誤");
            }
        }
    }
}

