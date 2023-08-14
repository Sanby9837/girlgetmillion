using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
                case 128:
                    P128();
                    break;
                case 132:
                    P132();
                    break;
                case 133:
                    P133();
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

        /// <summary>
        /// File
        /// </summary>
        static void P128()
        {
            //File.Create(@"C:\Users\User\Desktop\new.txt");
            //Console.WriteLine("建立完成");
            //Console.ReadKey();

            //File.Delete(@"C:\Users\User\Desktop\new.txt");
            //Console.WriteLine("刪除成功");
            //Console.ReadKey();

            File.Copy(@"C:\Users\User\Desktop\new.txt", @"C:\Users\User\Desktop\copy.txt");
            Console.WriteLine("複製完成");
            Console.ReadKey();
        }

        /// <summary>
        /// File
        /// </summary>
        static void P132()
        {
            //File.WriteAllLines(@"C:\\Users\\User\\Desktop\\new.txt",new string[] {"AAA","BBB"});
            //Console.WriteLine("建立完成");

            File.AppendAllText(@"C:\\Users\\User\\Desktop\\new.txt", "我是追加文字");
            Console.WriteLine("追加完成");
            Console.ReadKey();
        }

        /// <summary>
        /// List
        /// </summary>
        static void P133()
        {
            List<int> list_1 = new List<int>();
            list_1.Add(1);
            list_1.Add(2);

            list_1.AddRange(new int[] { 4, 5, 6 });
            list_1.AddRange(list_1);
            list_1.Remove(5);

            for (int i = 0; i < list_1.Count; i++)
            {
                Console.WriteLine(list_1[i]);
            }

            int[] list_array = list_1.ToArray();
            Console.ReadKey();
        }
    }
}
