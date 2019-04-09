using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.MyTodoList
{
    class MyToDo : IComparable<MyToDo>
    {
        public int ID { get; set; } = 0;
        //public int id;
        public DateTime CreateTime { get; set; }
        public string Content { get; set; }
        public enum SaveAs { Active, Completed };
        public SaveAs Save = SaveAs.Active;
        public bool IsActive => Save == SaveAs.Active;
        
        public MyToDo()
        {
            ID = 0;
            CreateTime = DateTime.Now;
            Content = "";
        }
        public MyToDo(MyToDo myTo)
        {
            ID = myTo.ID;
            CreateTime = myTo.CreateTime;
            Content = myTo.Content;
        }
        public MyToDo(string str, DateTime time,int id,SaveAs save = SaveAs.Active)
        {
            ID = id;
            Content = str;
            CreateTime = time;
            Save = save;
        }
        public override string ToString()
        {
            return "[ID]"+"["+ID+"]"+Content + " Created " + CreateTime;
        }
        public int CompareTo(MyToDo other)
        {
            return (ID - other.ID);
        }
    }
}

