using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
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
                case 112:
                    P112();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// string 介紹
        /// </summary>
        static void P111()
        {
            #region 將字串轉為char陣列
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
            #endregion

            #region 可變動字元字串StringBuilder
            //可變動的字元字串
            StringBuilder sb = new StringBuilder();
            //方法或屬性測量耗用時間
            Stopwatch sw = new Stopwatch();
            //計時器開始
            sw.Start();

            //將可變動字串加上字元
            //使用可變動字元字串賦值
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(i);
            }
            //計時器結束  00:00:00.0001328
            sw.Stop();

            //Console.WriteLine(sb.ToString());
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
            #endregion

            #region 不使用可變動字元去加上值，會開空間，所以時間比使用可變動字元加字還要長很多
            string sb2 = "";
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();

            //使用字元字串加值，耗用時間比StringBuilder還長很多
            for (int i = 0; i < 1000; i++)
            {
                sb2 += i;
            }
            //00:00:00.0017552
            sw2.Stop();

            //tostring可轉換為字串
            //Console.WriteLine(sb2.ToString());
            Console.WriteLine(sw2.Elapsed);
            Console.ReadKey();
            #endregion

            #region 練習題-請輸入一個名字，顯示他的字串長度
            Console.WriteLine("請輸入姓名，將協助您顯示姓名長度");
            string name = Console.ReadLine();
            Console.WriteLine($"長度是{name.Length}");
            Console.ReadKey();
            #endregion

            #region 練習題-輸入兩個學員各自喜歡的課程，如果有相同，就顯示相同的課程，如果不同，就顯示你們喜歡的課程不同
            Console.WriteLine("請問第一位同學，喜歡A、B、C哪一個課程呢?");
            string p111_likeclass1 = Console.ReadLine();
            //轉換成大寫
            p111_likeclass1 = p111_likeclass1.ToUpper();
            while (p111_likeclass1 != "A" && p111_likeclass1 != "B" && p111_likeclass1 != "C")
            {
                Console.WriteLine("請重新輸入A或B或C");
                p111_likeclass1 = Console.ReadLine();
                p111_likeclass1 = p111_likeclass1.ToUpper();
            }

            Console.WriteLine("請問第二位同學，喜歡A、B、C哪一個課程呢?");
            string p111_likeclass2 = Console.ReadLine();
            p111_likeclass2 = p111_likeclass2.ToUpper();
            while (p111_likeclass2 != "A" && p111_likeclass2 != "B" && p111_likeclass2 != "C")
            {
                Console.WriteLine("請重新輸入A或B或C");
                p111_likeclass2 = Console.ReadLine();
                p111_likeclass2 = p111_likeclass2.ToUpper();
            }

            //也可以透過Equals方法，使用StringComparison這個enum選擇OrdinalIgnoreCase方式比較
            if (p111_likeclass1.Equals(p111_likeclass2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"太好了! 你們都喜歡{p111_likeclass1}");
            }
            else
            {
                Console.WriteLine("不好意思，你們兩個喜歡的課程不相同呢! QQ");
            }
            Console.ReadKey();
            #endregion

            #region 分割字串 split
            string p111_split1 = "a_b+c  do,re^mi   da# la    la";
            char[] chs = { ' ', ',', '#', '^', '_', '+' };
            //使用Split方法，傳入欲移除的字元，第二個參數移除空白字串
            string[] p111_split2 = p111_split1.Split(chs, StringSplitOptions.RemoveEmptyEntries);

            //使用 string.Join 方法將 p111_split2 轉換回字串
            p111_split1 = String.Join("-", p111_split2);
            Console.WriteLine(p111_split1);
            Console.ReadKey();
            #endregion

            #region 練習題-請用戶輸入2023/07/25，接著將輸入的字串轉換為2023年7月25日
            Console.WriteLine("請輸入欲分析的日期");
            string p111_date = Console.ReadLine();
            char[] date_s = { '-', '/' };
            string[] p111_Date_Array = p111_date.Split(date_s, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"{p111_Date_Array[0]}年，{p111_Date_Array[1]}月，{p111_Date_Array[2]}日");
            Console.ReadKey();
            #endregion
        }

        /// <summary>
        /// string介紹2
        /// </summary>
        static void P112()
        {
            string p112_Str = "Sanby好可愛";

            //Contains 包含
            if (p112_Str.Contains("好可愛"))
            {
                //Replace替換
                p112_Str = p112_Str.Replace("好可愛", "在作夢");
            }
            Console.WriteLine(p112_Str);
            Console.ReadKey();

            //Substring 擷取 (從第5個下標開始擷，共擷3個位置)
            string p112_Str_2 = p112_Str.Substring(5, 3);
            Console.WriteLine(p112_Str_2);
            Console.ReadKey();

            //IndexOf找特定文字，第一次出現在第幾個位置
            //LastIndexOf找特定文字，最後一次出現在第幾個位置
            int index = p112_Str.IndexOf('y');
            Console.WriteLine(index);
            Console.ReadKey();

            string path = @"c:\a\b\v\d\dfs\vsadf\dfsevg\我好棒唷.doc";
            int index_1 = path.LastIndexOf("\\");
            path = path.Substring(index_1 + 1);
            Console.WriteLine(path);
            Console.ReadKey();
        }

    }
}
