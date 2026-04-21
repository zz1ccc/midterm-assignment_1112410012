namespace midterm_assignment_1112410012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // --- 檢查必填欄位 ---
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("請填寫姓名！", "提示");
                return;
            }

            // 2. 補齊：檢查國籍 (ComboBox)
            // SelectedIndex == -1 代表使用者「完全沒有選」任何選項
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇國籍！", "資料不完整");
                comboBox1.DroppedDown = true; // 自動彈開下拉選單，提醒使用者選
                return;
            }

            // --- 取得性別 ---
            string gender = radioButton1.Checked ? "男" : "女";

            // --- 取得興趣 ---
            string interests = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                interests += item.ToString() + " ";
            }

            // --- 組合所有結果文字 ---
            string result = "【填寫資料確認】\r\n";
            result += $"姓名：{textBox1.Text}\r\n";
            result += $"性別：{gender}\r\n";
            result += $"生日：{dateTimePicker1.Value.ToShortDateString()}\r\n";
            result += $"國籍：{comboBox1.Text}\r\n";
            result += $"地址：{textBox2.Text}\r\n";
            result += $"電話：{textBox3.Text}\r\n";
            result += $"Email：{textBox4.Text}\r\n";
            result += $"興趣：{interests}\r\n";
            result += $"備註：{textBox5.Text}";

            // --- 顯示到最下面的大框框 ---
            // 假設你最下面那個結果框是 textBox6
            textBox6.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. 取得輸入框 textBox7 的內容，並去掉前後空白
            string newItem = textBox7.Text.Trim();

            // 2. 判斷有沒有輸入東西
            if (!string.IsNullOrWhiteSpace(newItem))
            {
                // 3. 檢查清單中是否已經有重複的興趣
                if (!checkedListBox1.Items.Contains(newItem))
                {
                    // 4. 新增到 CheckedListBox 中
                    checkedListBox1.Items.Add(newItem);

                    // 5. 新增後自動勾選 (讓使用者不用再點一次，更方便)
                    int index = checkedListBox1.Items.IndexOf(newItem);
                    checkedListBox1.SetItemChecked(index, true);

                    // 6. 清空 textBox7 方便下次輸入
                    textBox7.Clear();
                }
                else
                {
                    MessageBox.Show("這個興趣已經在清單裡囉！", "提示");
                }
            }
            else
            {
                MessageBox.Show("請先輸入想要新增的興趣名稱。", "提示");
            }
        }
    }
}
