using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTest.Models
{
    public class TodoDataContainer
    {
        public List<TodoItem> TodoItems { get; set; }
        private int maxId;

        public TodoDataContainer()
        {
            TodoItems = new List<TodoItem>();
            maxId = 0;
            GenerateRandomData();
        }

        public int GetNextId()
        {
            maxId++;
            return maxId;
        }

        public void AddTodoItem(string title, string content, DateTime endTime, int status)
        {
            int newId = GetNextId();
            TodoItem item = new TodoItem(newId, title, content, endTime, DateTime.Now, status);
            TodoItems.Add(item);
        }

        public bool RemoveTodoItem(int id)
        {
            var item = TodoItems.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                TodoItems.Remove(item);
                return true;
            }
            return false;
        }

        public TodoItem GetTodoItemById(int id)
        {
            return TodoItems.FirstOrDefault(x => x.Id == id);
        }

        private void GenerateRandomData()
        {
            Random random = new Random();

            var todoData = new (string title, string content)[]
            {
                ("完成專案報告", "需要在期限內完成所有章節並進行校對"),
                ("購買生活用品", "採購清單包含日用品和食材"),
                ("預約醫生", "安排定期健康檢查和諮詢"),
                ("準備會議簡報", "準備下週部門會議的相關資料"),
                ("整理房間", "整理衣櫃和書桌，丟棄不需要的物品"),
                ("學習新技能", "學習程式設計相關技術"),
                ("學習新技能", "學習英語口語表達能力"),
                ("學習新技能", "學習UI/UX設計基礎知識"),
                ("運動健身", "維持每週三次的運動習慣"),
                ("閱讀書籍", "閱讀專業相關書籍增進知識"),
                ("拜訪朋友", "安排時間與久未見面的朋友聚餐"),
                ("拜訪朋友", "探望住院的老同學並帶些慰問品"),
                ("規劃旅行", "研究目的地並制定詳細行程"),
                ("維修電腦", "檢查硬體設備並更新軟體"),
                ("繳納帳單", "確認所有費用已按時繳納"),
                ("清理信箱", "刪除垃圾郵件並整理重要信件"),
                ("準備考試", "複習考試範圍並做練習題"),
                ("準備考試", "整理筆記並製作重點摘要"),
                ("準備考試", "練習歷年考古題加強應試能力"),
                ("準備考試", "報名參加考前衝刺班課程"),
                ("參加研習", "參加職業發展相關課程"),
                ("寫作計畫", "開始撰寫個人部落格文章"),
                ("健康檢查", "預約年度健康檢查項目"),
                ("投資理財", "研究基金投資組合配置"),
                ("學習烹飪", "學習製作家常料理菜色"),
                ("整理文件", "掃描重要文件並建立數位檔案"),
                ("社交活動", "參加社區志工服務活動"),
                ("技能提升", "報名參加線上課程提升專業技能"),
                ("家庭聚會", "籌備家族聚餐活動安排"),
                ("購物計畫", "制定下個月的採購預算清單"),
                ("休閒娛樂", "安排週末電影院觀影計畫"),
                ("工作規劃", "制定下季度的工作目標與時程")
            };

            DateTime startDate = new DateTime(2025, 8, 25);
            DateTime endDate = new DateTime(2025, 9, 30);
            int totalDays = (endDate - startDate).Days;

            for (int i = 0; i < todoData.Length; i++)
            {
                DateTime createTime = startDate.AddDays(random.Next(0, totalDays + 1))
                    .AddHours(random.Next(0, 24))
                    .AddMinutes(random.Next(0, 60));

                DateTime endTime = createTime.AddDays(random.Next(7, 15))
                    .AddHours(random.Next(0, 24))
                    .AddMinutes(random.Next(0, 60));

                int status = random.Next(0, 4);

                TodoItem item = new TodoItem(
                    GetNextId(),  // 使用GetNextId()確保ID唯一性
                    todoData[i].title,
                    todoData[i].content,
                    endTime,
                    createTime,
                    status
                );

                TodoItems.Add(item);
            }
        }
    }
}