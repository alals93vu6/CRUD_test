using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDTest.Models;

namespace CRUDTest.Scripts.Controllers
{
    public class DataController
    {
        
        public DataController()
        {

        }

        public List<TodoItem> OnQueryDate(int page, TodoDataContainer data)
        {
            // 每頁顯示5筆，根據頁面將對應的資料分頁，並return1~5筆的LIST
            int pageSize = 5;
            int startIndex = (page - 1) * pageSize;

            return data.TodoItems.Skip(startIndex).Take(pageSize).ToList();
        }

        public List<TodoItem> OnQueryDate(string keyword, TodoDataContainer data)
        {
            // Query模式，根據關鍵字輸出對應的資料分頁，並return符合的LIST，關鍵字TITLE相同，包含內容相符
            return data.TodoItems
                .Where(item => item.Title.Contains(keyword) || item.Content.Contains(keyword))
                .ToList();
        }
    }
}