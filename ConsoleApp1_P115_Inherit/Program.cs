using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P115_Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("學生",18,'女',10224087);
            Console.WriteLine($"{s1.Name},{s1.Age},{s1.Gender},{s1.Id}");
            s1.Study();
            s1.Self();
            Console.ReadKey();
        }
    }
}
