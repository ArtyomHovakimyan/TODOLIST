using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.MyTodoList
{
    class MyToDo : IComparable<MyToDo>
    {
        public static int ID { get; set; } = 0;
        public int id;
        public DateTime CreateTime { get; set; }
        public string Content { get; set; }
        public enum SaveAs { Active, Completed };
        public SaveAs Save = SaveAs.Active;
        public bool IsActive => Save == SaveAs.Active;
        static MyToDo()
        {
            ID++;
        }
        public MyToDo()
        {
            ID = id + 1; 
            id = ID;
            CreateTime = DateTime.Now;
            Content = "";
        }
        public MyToDo(string str, DateTime time,SaveAs save = SaveAs.Active)
        {
            Content = str;
            CreateTime = time;
            Save = save;
        }
        public override string ToString()
        {
            return "[ID]"+"["+id+"]"+Content + " Created " + CreateTime;
        }
        public int CompareTo(MyToDo other)
        {
            return MyToDo.ID - other.id;
        }
    }
}

