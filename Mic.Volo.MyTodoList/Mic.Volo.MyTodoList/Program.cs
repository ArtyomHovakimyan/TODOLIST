using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.MyTodoList
{
    class Program
    {
        static int IDS = 0;
        static void Main(string[] args)
        {
            List<MyToDo> MyToDosTask = new List<MyToDo>();
            MyLabel:
            Console.WriteLine("If you want create  new  todo  press 1");
            Console.WriteLine("If  you has todo press 2 to show  all");
            Console.WriteLine("If  you has active todo press 3 to show");
            Console.WriteLine("delete todo  press 4 and  enter Id ");
            Console.WriteLine(" press 5 enter Id which you want make completed");
            Console.WriteLine("press 6 show completed todos");
            string mutq;
            int indexID;
            byte n;
            //IEnumerable<MyToDo> myTos;
            n = byte.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: Console.WriteLine("Enter your text:");
            mutq = Console.ReadLine();
                    MyToDosTask.Add(new MyToDo(mutq,DateTime.Now,IDS));
                    goto default;
                   // break;
                case 2: Show(MyToDosTask);
                    goto default;
                    //break;

                case 3: ShowIsActive(MyToDosTask);
                    goto default;
                // break;
                case 4:
                    Console.WriteLine("enter ID which you want to delete:");
                    indexID = int.Parse(Console.ReadLine());
                    MyToDosTask.RemoveAt(indexID);
                    goto default;

                case 5: Console.WriteLine("enter ID which you want to make completed:");
                    indexID = int.Parse(Console.ReadLine());

                    IEnumerable<MyToDo> myTos= MakeCompleted(MyToDosTask, indexID);
                    goto default;
                case 6: ShowCompleted(MakeCompleted(MyToDosTask));
                    goto default;
                //break;
                default: IDS++; goto MyLabel;
            }


        }
        static void ShowIsActive(List<MyToDo> mies)
        {
            var f = from i in mies
                    where i.IsActive
                    select i;
            foreach (var item in f)
            {
                Console.WriteLine(item);
            }
        }
        static void Show(List<MyToDo> mies)
        {
            var f = from i in mies
                    select i;
            foreach (var item in f)
            {
                Console.WriteLine(item);
            }
        }
        static  MakeCompleted(List<MyToDo> mies,params int[] id)
        {
           
              
        }
        static void ShowCompleted(IEnumerable<MyToDo> dos)
        {
            var a = from i in dos
                    where i.Save == MyToDo.SaveAs.Completed
                    select i;
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }

    }
}
