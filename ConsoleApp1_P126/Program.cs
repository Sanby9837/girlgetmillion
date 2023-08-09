using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P126
{
    internal class Program
    {
        public const String Traditional = "繁體偵測語試";
        public const String Simplified = "简体侦1语2";
        static void Main(string[] args)
        {
            Console.WriteLine("Where u go?");
            int go = Convert.ToInt32(Console.ReadLine());
            switch (go)
            {
                case 126:
                    P126();
                    break;

                default: break;
            }
        }

        /// <summary>
        /// Hashtable練習
        /// </summary>
        static void P126()
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < Traditional.Length; i++)
            {
                ht.Add(Traditional[i], Simplified[i]);
            }

            Console.WriteLine("請輸入繁體，幫你轉換成簡體");
            string intput = Console.ReadLine();
            for (int i = 0; i < intput.Length; i++)
            {
                if (ht.Contains(intput[i]))
                {
                    Console.Write(ht[intput[i]]);
                }
                else
                {
                    Console.Write(intput[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
