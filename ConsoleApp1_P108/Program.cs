using ConsoleApp1_P98; //引用其他專案的class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //引用其他專案的class
            Console.WriteLine("請輸入距離");
            Ticket t2 = new Ticket(Convert.ToDouble(Console.ReadLine()));
            t2.ShowTicket();

            Console.ReadKey();
        }
    }
}
