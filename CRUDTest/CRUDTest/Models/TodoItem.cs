using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTest.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateTime { get; set; }
        public int Status { get; set; }

        public TodoItem(int id, string title, string content, DateTime endTime, DateTime createTime, int status)
        {
            Id = id;
            Title = title;
            Content = content;
            EndTime = endTime;
            CreateTime = createTime;
            Status = status;
        }
    }
}