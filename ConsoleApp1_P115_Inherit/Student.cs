using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P115_Inherit
{
    internal class Student : Person
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void Study()
        {
            Console.WriteLine($"學生需要會讀書，學號是{Id}");
        }

        public new void Self()
        {
            Console.WriteLine("這是學生的自我介紹");
        }

        public Student(string Name, int Age, char Gender, int Id) : base(Name,Age,Gender)
        {
            this.Id = Id;
        }
    }
}
