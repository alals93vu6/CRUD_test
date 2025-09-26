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
using CRUDTest.Models;

namespace CRUDTest
{
    public partial class Form2 : Form
    {
        private EditFormManager editFormManager;
        private bool isDataChanged = false;

        public Form2(TodoDataContainer dataContainer, int itemId)
        {
            InitializeComponent();
            editFormManager = new EditFormManager(dataContainer);
            editFormManager.InitializeForm(this, itemId);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 設定視窗標題
            this.Text = "編輯事件";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var formData = GetFormData();
            bool success = editFormManager.UpdateItem(formData.title, formData.content, formData.endTime, formData.status);

            if (success)
            {
                isDataChanged = true;
                this.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool success = editFormManager.DeleteItem();

            if (success)
            {
                isDataChanged = true;
                this.Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private (string title, string content, DateTime endTime, int status) GetFormData()
        {
            string title = titleTextBox.Text;
            string content = contentTextBox.Text;
            DateTime endTime = endTimePicker.Value;

            int status = 0;
            if (checkBox_inProgress.Checked) status = 1;
            else if (checkBox_completed.Checked) status = 2;
            else if (checkBox_finished.Checked) status = 3;
            // 預設是準備中 (0)

            return (title, content, endTime, status);
        }

        public void LoadItemToForm(TodoItem item)
        {
            titleTextBox.Text = item.Title;
            contentTextBox.Text = item.Content;
            endTimePicker.Value = item.EndTime;

            // 重置所有CheckBox
            checkBox_preparing.Checked = false;
            checkBox_inProgress.Checked = false;
            checkBox_completed.Checked = false;
            checkBox_finished.Checked = false;

            // 設定對應的狀態
            switch (item.Status)
            {
                case 0: checkBox_preparing.Checked = true; break;
                case 1: checkBox_inProgress.Checked = true; break;
                case 2: checkBox_completed.Checked = true; break;
                case 3: checkBox_finished.Checked = true; break;
            }
        }

        public bool IsDataChanged
        {
            get { return isDataChanged; }
        }

        private void statusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedBox = sender as CheckBox;
            if (clickedBox.Checked)
            {
                // 確保只有一個CheckBox被選中
                checkBox_preparing.Checked = (clickedBox == checkBox_preparing);
                checkBox_inProgress.Checked = (clickedBox == checkBox_inProgress);
                checkBox_completed.Checked = (clickedBox == checkBox_completed);
                checkBox_finished.Checked = (clickedBox == checkBox_finished);
            }
        }
    }
}