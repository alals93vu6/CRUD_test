using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDTest.Scripts.Controllers;
using CRUDTest.Models;

namespace CRUDTest.Scripts.Managers
{
    public class TodoListManager
    {
        private UIController uIController = new UIController();
        private DataController dataController = new DataController();
        private TodoDataContainer data;
        private string currentKeyword = "";

        public int CurrentPage = 1;

        public TodoListManager()
        {

        }

        public void OnStart()
        {
            data = new TodoDataContainer();
            QueryList("");
        }

        public void OnStart(Form1 form)
        {
            data = new TodoDataContainer();
            uIController.SetForm(form);
            uIController.MaxPagerDetected(data.TodoItems.Count);
            QueryList("");
        }


        public void QueryList(string keyword)
        {
            // 如果是新的搜尋，重置到第1頁
            if (currentKeyword != keyword)
            {
                CurrentPage = 1;
            }
            currentKeyword = keyword;  // 保存當前搜尋關鍵字

            List<TodoItem> result;
            int totalCount;

            if (keyword != "")
            {
                // 搜尋模式：取得所有符合條件的資料
                var allResults = dataController.OnQueryDate(keyword, data);
                totalCount = allResults.Count;

                // 重新分頁處理搜尋結果
                int pageSize = 5;
                int startIndex = (CurrentPage - 1) * pageSize;
                result = allResults.Skip(startIndex).Take(pageSize).ToList();
            }
            else
            {
                // 一般分頁模式
                result = dataController.OnQueryDate(CurrentPage, data);
                totalCount = data.TodoItems.Count;
            }

            uIController.MaxPagerDetected(totalCount);
            uIController.OnChangePage(CurrentPage);
            uIController.UpdateView(result, totalCount);
        }

        public void ChangePage(int page)
        {
            CurrentPage += page;
            QueryList(currentKeyword);  // 使用當前的搜尋關鍵字
        }

        public void AddTodoItem(string title, string content, DateTime endTime, int status)
        {
            data.AddTodoItem(title, content, endTime, status);

            // 重新整理當前頁面顯示
            uIController.MaxPagerDetected(data.TodoItems.Count);
            QueryList(currentKeyword);
        }

        public void OpenEditForm(int buttonIndex, Form1 parentForm)
        {
            // 根據按鈕索引和當前頁面計算實際的資料索引
            int dataIndex = (CurrentPage - 1) * 5 + buttonIndex;

            // 取得當前頁面的資料
            List<TodoItem> currentPageData = GetCurrentPageData();

            if (buttonIndex < currentPageData.Count)
            {
                int itemId = currentPageData[buttonIndex].Id;

                Form2 editForm = new Form2(data, itemId);
                editForm.ShowDialog(parentForm);

                // 如果資料有變更，重新整理顯示
                if (editForm.IsDataChanged)
                {
                    uIController.MaxPagerDetected(data.TodoItems.Count);
                    QueryList(currentKeyword);
                }
            }
        }

        private List<TodoItem> GetCurrentPageData()
        {
            if (currentKeyword != "")
            {
                // 搜尋模式
                var allResults = dataController.OnQueryDate(currentKeyword, data);
                int pageSize = 5;
                int startIndex = (CurrentPage - 1) * pageSize;
                return allResults.Skip(startIndex).Take(pageSize).ToList();
            }
            else
            {
                // 一般分頁模式
                return dataController.OnQueryDate(CurrentPage, data);
            }
        }
    }
}