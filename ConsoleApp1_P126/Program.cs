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
                case 134:
                    P134();
                    break;
                case 135:
                    P135();
                    break;
                case 136:
                    P136();
                    break;
                case 137:
                    P137();
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

        /// <summary>
        /// 裝箱、拆箱
        /// </summary>
        static void P134()
        {
            int n = 10;
            // 值類型裝箱成引用類型
            object o = n;

            // 引用類型拆箱成值類型
            int nn = (int)o;
        }

        /// <summary>
        /// Dictionary
        /// </summary>
        static void P135()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "老高");
            dic.Add(2, "小茉");
            dic.Add(3, "三歲抬頭");
            dic[1] = "歡迎光臨";

            foreach (KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine($"Key {kvp.Key}，值  {kvp.Value}");
            }

            //foreach (var item in dic.Keys)
            //{
            //    Console.WriteLine($"key {item}  值  {dic[item]}"); 
            //}
            Console.ReadLine();
        }

        /// <summary>
        /// 集合的練習題
        /// </summary>
        static void P136()
        {
            //練習題：將一個陣列中的奇數、偶數各自放到兩個陣列中，
            //最後將兩個陣列轉成一個集合，奇數顯示在左邊，偶數顯示在右邊
            int[] int_Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> list_i = new List<int>();
            List<int> list_ii = new List<int>();
            for (int i = 0; i < int_Array.Length; i++)
            {
                if (int_Array[i] % 2 == 0)
                {
                    list_ii.Add(int_Array[i]);
                }
                else
                {
                    list_i.Add(int_Array[i]);
                }
            }

            List<int> list_all = new List<int>();
            list_all.AddRange(list_i);
            list_all.AddRange(list_ii);

            foreach (int i in list_all)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
            Console.WriteLine("-------------------------");
            //輸入字串，透過foreach將輸入的字串賦值給一個字串陣列
            Console.WriteLine("請輸入字串");
            string str_1 = Console.ReadLine();

            //也可以指宣告為陣列
            //char[] char_1 = new char[str_1.Length];
            List<char> char_1 = new List<char>();
            foreach (var item in str_1)
            {
                char_1.Add(item);
            }

            for (int i = 0; i < char_1.Count; i++)
            {
                Console.Write($"{char_1[i]}    ");
            }
            Console.ReadKey();
            Console.WriteLine("-------------------------");

            //統計 Welcome to Taiwan每個字出現的字數，不考慮大小寫
            string str_3 = "Welcome to Taiwan";
            string str_3_low = str_3.ToLower();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var item in str_3_low)
            {
                if (item == ' ')
                {
                    continue;
                }
                //如果已經有出現過，則出現次數(值+1)
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                //沒出現過就加元素進去，而且值是1
                else
                {
                    dic[item] = 1;
                }
            }
            foreach (var item in dic.Keys)
            {
                Console.WriteLine($"{item}出現了{dic[item]}次");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// FileStream
        /// </summary>
        static void P137()
        {
            FileStream fsRead = new FileStream(@"C:\Users\User\Desktop\137test.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 5];
            //return 本次實際讀到的有效字節
            int i = fsRead.Read(buffer, 0, buffer.Length);
            //將字節每一個元素按照指定的編碼格式解碼成字串
            string book = Encoding.UTF8.GetString(buffer,0,i);
            //關閉資料流
            fsRead.Close();
            //釋放資料流占用的資源
            fsRead.Dispose();

            Console.WriteLine(book);
            Console.ReadKey();

            //用using(){}包起來，可以自行關閉釋放資料流
            using (FileStream fsWrite = new FileStream(@"C:\Users\User\Desktop\137test.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                Console.WriteLine("請輸入想要加入的文字");
                string str = Console.ReadLine();
                byte[] write_byte = Encoding.UTF8.GetBytes(str);
                fsWrite.Write(write_byte,0,write_byte.Length);
                Console.WriteLine("寫入完成");
                Console.ReadKey();
            }
        }
    }
}
