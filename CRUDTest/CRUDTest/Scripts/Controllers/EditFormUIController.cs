using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDTest.Models;

namespace CRUDTest.Scripts.Controllers
{
    public class EditFormUIController
    {
        private Form2 form;
        private TextBox titleTextBox;
        private TextBox contentTextBox;
        private DateTimePicker endTimePicker;
        private CheckBox[] statusCheckBoxes;
        private Button confirmButton;
        private Button deleteButton;
        private Button closeButton;

        public void SetForm(Form2 form)
        {
            this.form = form;
            InitializeControls();
        }

        private void InitializeControls()
        {
            if (form == null) return;

            // 根據你的Form2控件名稱來找控件
            titleTextBox = form.Controls.Find("titleTextBox", true).FirstOrDefault() as TextBox;
            contentTextBox = form.Controls.Find("contentTextBox", true).FirstOrDefault() as TextBox;
            endTimePicker = form.Controls.Find("endTimePicker", true).FirstOrDefault() as DateTimePicker;

            // 假設狀態用CheckBox實作，你需要根據實際控件名稱調整
            statusCheckBoxes = new CheckBox[4];
            statusCheckBoxes[0] = form.Controls.Find("checkBox_preparing", true).FirstOrDefault() as CheckBox;
            statusCheckBoxes[1] = form.Controls.Find("checkBox_inProgress", true).FirstOrDefault() as CheckBox;
            statusCheckBoxes[2] = form.Controls.Find("checkBox_completed", true).FirstOrDefault() as CheckBox;
            statusCheckBoxes[3] = form.Controls.Find("checkBox_finished", true).FirstOrDefault() as CheckBox;

            confirmButton = form.Controls.Find("confirmButton", true).FirstOrDefault() as Button;
            deleteButton = form.Controls.Find("deleteButton", true).FirstOrDefault() as Button;
            closeButton = form.Controls.Find("closeButton", true).FirstOrDefault() as Button;
        }

        public void LoadItemToForm(TodoItem item)
        {
            if (titleTextBox != null) titleTextBox.Text = item.Title;
            if (contentTextBox != null) contentTextBox.Text = item.Content;
            if (endTimePicker != null) endTimePicker.Value = item.EndTime;

            // 設定狀態CheckBox
            if (statusCheckBoxes != null)
            {
                for (int i = 0; i < statusCheckBoxes.Length; i++)
                {
                    if (statusCheckBoxes[i] != null)
                    {
                        statusCheckBoxes[i].Checked = (i == item.Status);
                    }
                }
            }
        }

        public (string title, string content, DateTime endTime, int status) GetFormData()
        {
            string title = titleTextBox?.Text ?? "";
            string content = contentTextBox?.Text ?? "";
            DateTime endTime = endTimePicker?.Value ?? DateTime.Now;

            int status = 0;
            if (statusCheckBoxes != null)
            {
                for (int i = 0; i < statusCheckBoxes.Length; i++)
                {
                    if (statusCheckBoxes[i]?.Checked == true)
                    {
                        status = i;
                        break;
                    }
                }
            }

            return (title, content, endTime, status);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ConfirmDelete()
        {
            DialogResult result = MessageBox.Show(
                "確定要刪除這個事件嗎？此操作無法復原。",
                "確認刪除",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            return result == DialogResult.Yes;
        }
    }
}