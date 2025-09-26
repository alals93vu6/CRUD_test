using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDTest.Scripts.Managers;

namespace CRUDTest
{
    public partial class Form1: Form
    {
        private TodoListManager todoListManager;

        public Form1()
        {
            InitializeComponent();
            todoListManager = new TodoListManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 設定預設值
            dateTimePicker1.Value = DateTime.Now.AddDays(7);  // 預設結束時間為今天+7天
            comboBox1.SelectedIndex = 0;  // 預設狀態為「準備中」

            todoListManager.OnStart(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            todoListManager.OpenEditForm(0, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            todoListManager.OpenEditForm(1, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            todoListManager.OpenEditForm(2, this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            todoListManager.OpenEditForm(3, this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            todoListManager.OpenEditForm(4, this);
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            todoListManager.ChangePage(-1);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            todoListManager.ChangePage(1);
        }

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            todoListManager.QueryList(textBox_QueryKetword.Text);
        }

        private void CleanBtn_Click(object sender, EventArgs e)
        {
            // 清空標題和內容輸入框
            textBox_Title.Text = "";
            textBox_Content.Text = "";

            // 重置為預設值
            dateTimePicker1.Value = DateTime.Now.AddDays(7);
            comboBox1.SelectedIndex = 0;

            // 清除錯誤提示
            logText.Text = "";
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            // 標題必填驗證
            if (string.IsNullOrWhiteSpace(textBox_Title.Text))
            {
                logText.Text = "錯誤：事件標題為必填欄位";
                return;
            }

            // 取得輸入值
            string title = textBox_Title.Text.Trim();
            string content = textBox_Content.Text.Trim();
            DateTime endTime = dateTimePicker1.Value;
            int status = comboBox1.SelectedIndex;

            // 新增事件
            todoListManager.AddTodoItem(title, content, endTime, status);

            // 清空表單
            CleanBtn_Click(sender, e);

            // 顯示成功訊息
            logText.Text = "成功新增事件！";
        }
    }
}
