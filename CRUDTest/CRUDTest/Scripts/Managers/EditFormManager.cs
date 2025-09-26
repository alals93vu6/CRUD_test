using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDTest.Models;
using CRUDTest.Scripts.Controllers;

namespace CRUDTest.Scripts.Managers
{
    public class EditFormManager
    {
        private Form2 form;
        private TodoDataContainer dataContainer;
        private int currentItemId;

        public EditFormManager(TodoDataContainer dataContainer)
        {
            this.dataContainer = dataContainer;
        }

        public void InitializeForm(Form2 form, int itemId)
        {
            this.form = form;
            currentItemId = itemId;
            LoadItemData();
        }

        private void LoadItemData()
        {
            var item = dataContainer.GetTodoItemById(currentItemId);
            if (item != null)
            {
                form.LoadItemToForm(item);
            }
        }

        public bool UpdateItem(string title, string content, DateTime endTime, int status)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("標題為必填欄位", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var item = dataContainer.GetTodoItemById(currentItemId);
            if (item != null)
            {
                item.Title = title.Trim();
                item.Content = content.Trim();
                item.EndTime = endTime;
                item.Status = status;

                MessageBox.Show("更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            MessageBox.Show("找不到對應的事件資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool DeleteItem()
        {
            DialogResult result = MessageBox.Show(
                "確定要刪除這個事件嗎？此操作無法復原。",
                "確認刪除",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bool success = dataContainer.RemoveTodoItem(currentItemId);
                if (success)
                {
                    MessageBox.Show("刪除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("刪除失敗", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }
    }
}