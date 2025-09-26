using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDTest.Models;


namespace CRUDTest.Scripts.Controllers
{
    
    public class UIController
    {
        private Form1 form;
        private Button[] todoButtons;
        private Label pageLabel;
        private Button previousButton;
        private Button nextButton;
        private Label logText;
        private int maxPage;

        public UIController()
        {
            // 在 TodoListManager 中初始化時會傳入 Form 參考
        }

        public void SetForm(Form1 form)
        {
            this.form = form;
            InitializeControls();
        }

        private void InitializeControls()
        {
            if (form == null) return;

            todoButtons = new Button[] {
                form.Controls.Find("button1", true).FirstOrDefault() as Button,
                form.Controls.Find("button2", true).FirstOrDefault() as Button,
                form.Controls.Find("button3", true).FirstOrDefault() as Button,
                form.Controls.Find("button4", true).FirstOrDefault() as Button,
                form.Controls.Find("button5", true).FirstOrDefault() as Button
            };

            pageLabel = form.Controls.Find("NowPageText", true).FirstOrDefault() as Label;
            previousButton = form.Controls.Find("PreviousBtn", true).FirstOrDefault() as Button;
            nextButton = form.Controls.Find("NextBtn", true).FirstOrDefault() as Button;
            logText = form.Controls.Find("logText", true).FirstOrDefault() as Label;
        }

        public void UpdateView(List<TodoItem> todoDataContainer)
        {
            BtnDetected(todoDataContainer.Count);
            BtnUpdate(todoDataContainer);
        }

        public void UpdateView(List<TodoItem> todoDataContainer, int totalCount)
        {
            BtnDetected(todoDataContainer.Count);
            BtnUpdate(todoDataContainer);
            UpdateLogText(totalCount);
        }

        private void BtnDetected(int dataCount)
        {
            //每頁有五個按鈕，偵測當前的資料是否滿5筆，設當頁4筆則隱藏最後一個按鈕，3筆則隱藏最後兩個按鈕，以此類推
            if (todoButtons == null) return;

            for (int i = 0; i < todoButtons.Length; i++)
            {
                if (todoButtons[i] != null)
                {
                    todoButtons[i].Visible = i < dataCount;
                }
            }
        }

        private void BtnUpdate(List<TodoItem> todoDataContainer)
        {
            if (todoButtons == null || todoDataContainer == null) return;

            for (int i = 0; i < todoButtons.Length && i < todoDataContainer.Count; i++)
            {
                if (todoButtons[i] != null)
                {
                    var item = todoDataContainer[i];
                    todoButtons[i].Text = $"{item.Title}\n{item.Content}\n結束時間：{item.EndTime:yyyy/MM/dd}";

                    // 設定按鈕顏色
                    todoButtons[i].BackColor = GetButtonColor(item);
                    todoButtons[i].UseVisualStyleBackColor = false;
                }
            }
        }

        private Color GetButtonColor(TodoItem item)
        {
            // 檢查是否超過結束時間且狀態不是完成或結束
            bool isOverdue = DateTime.Now > item.EndTime && item.Status != 2 && item.Status != 3;

            if (isOverdue)
            {
                return Color.LightSalmon; // 紅色 (過期)
            }

            // 根據狀態設定顏色
            switch (item.Status)
            {
                case 0: return Color.LightGray;    // 準備中 - 淡灰色
                case 1: return Color.LightBlue;    // 進行中 - 淡藍色
                case 2: return Color.LightGreen;   // 完成 - 綠色
                case 3: return Color.DarkGray;     // 結束 - 深灰色
                default: return Color.LightGray;
            }
        }

        public void OnChangePage(int page)
        {
            PageTextDetected(page);
            BtnStatusDetected(page);
        }

        private void PageTextDetected(int page)
        {
            pageLabel.Text = $"當前位於第{page}頁";
        }

        private void BtnStatusDetected(int page)
        {
            //檢查當前頁數，若為第一頁則無法再往前翻頁，若為最後一頁則無法再往後翻頁，反之讓兩個btn正常使用
            if (previousButton != null)
            {
                previousButton.Enabled = page > 1;
            }

            // 這裡需要知道總頁數才能正確判斷，暫時先啟用
            if (nextButton != null)
            {
                nextButton.Enabled = page < maxPage; 
            }
        }

        public void MaxPagerDetected(int count)
        {
            maxPage = (int)Math.Ceiling(count / 5.0);
        }

        private void UpdateLogText(int count)
        {
            if (logText != null)
            {
                logText.Text = $"找到 {count} 筆資料";
            }
        }
    }
}