using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class Program
    {
        class Teacher {
            public string name;
            public string subject;
        }

        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher() { name = "함기훈", subject = "정보컴퓨터" });
            list.Add(new Teacher() { name = "박성래", subject = "수학" });
            list.Add(new Teacher() { name = "민주리", subject = "정보컴퓨터" });
            list.Add(new Teacher() { name = "박지우", subject = "정보컴퓨터" });
            list.Add(new Teacher() { name = "김보경", subject = "가정" });
            list.Add(new Teacher() { name = "장민주", subject = "디자인" });

            for (int i = list.Count-1; i >=0; i--) {
                if (list[i].subject == "정보컴퓨터")
                    list.RemoveAt(i);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.subject);
            }


        }
    }
}
