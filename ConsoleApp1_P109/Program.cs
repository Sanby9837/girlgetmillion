using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("where u wannat go?");
            int go = Convert.ToInt32(Console.ReadLine());

            switch (go)
            {
                case 111:
                    P111();
                    break;

                default:
                    break;
            }
        }

        static void P111()
        {
            string s = "abcde";
            Console.WriteLine($"變更前{s[0]}");
            
            //將字串轉為char陣列
            char[] charsss = s.ToCharArray();
            //把第0位變更為b
            charsss[0] = 'b';

            //把陣列利用new轉回去字串
            s = new string(charsss);
            Console.WriteLine($"變更後{s[0]}");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
