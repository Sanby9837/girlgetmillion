using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P98
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where u go?");
            int goesto = Convert.ToInt32(Console.ReadLine());
            switch (goesto)
            {
                case 98:
                    P98();
                    break;

                default:
                    break;
            }
        }

        static void P98()
        {
            //實例化Person這個類的物件
            Person sanby = new Person();
            sanby._name = "33";
            sanby._age = 28;
            sanby._gender = '女';

            //調用sanby這個物件去執行Person類下的自我介紹方法
            sanby.Self();
            Console.ReadKey();
        }
    }
}
