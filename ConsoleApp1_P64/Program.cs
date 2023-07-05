using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P64
{
    /// <summary>
    /// P65 列舉宣告
    /// </summary>
    public enum Gender
    {
        男,
        女,
    }

    /// <summary>
    /// P66 列舉宣告
    /// </summary>
    public enum QQState
    {
        Online = 3,
        OffLine,
        Leave,
        Busy,
        CallMe,
    }

    /// <summary>
    /// P67結構 struct
    /// </summary>
    public struct Person
    {
        public string _p67_name; //字段，與變量不同的是可以儲存很多值，命名建議第一碼加下底線
        public int _p67_age;
        public Gender _p67_gender;
    }

    /// <summary>
    /// P67 結構練習
    /// </summary>
    public struct MyColor
    {
        public int _p67_red;
        public int _p67_green;
        public int _p67_blue;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where u go ???");
            string go = Console.ReadLine();


            switch (go)
            {
                case "64":
                    P64();
                    break;
                case "65":
                    P65();
                    break;
                case "66":
                    P66();
                    break;
                case "67":
                    P67();
                    break;
                case "68":
                    P68();
                    break;
                case "69":
                    P69();
                    break;
                case "70":
                    P70();
                    break;
                case "71":
                    P71();
                    break;
                case "72":
                    P72();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// P64 常量-不可變的值
        /// </summary>
        static void P64()
        {
            const int p64_const_int = 20; //常量，不能被重新賦值。
            Console.WriteLine($"{p64_const_int}");
            Console.ReadKey();
        }

        /// <summary>
        /// P65 列舉
        /// </summary>
        static void P65()
        {
            //將列舉資料拿起來使用
            Gender p65_Gender = Gender.男;
            Console.WriteLine($"{p65_Gender}");
            Console.ReadKey();
        }

        /// <summary>
        /// P66 列舉的練習
        /// </summary>
        static void P66()
        {
            //列舉轉int
            //將列舉的值拿出來給p66_Open
            QQState p66_Open = QQState.OffLine;
            //強制將列舉轉為int給p66_OpenInt
            int p66_OpenInt = (int)p66_Open;
            Console.WriteLine($"列舉轉int  {p66_OpenInt}");
            Console.ReadKey();

            //列舉轉string
            string p66_OpenString = p66_Open.ToString();
            Console.WriteLine($"列舉轉字串  {p66_OpenString}");
            Console.ReadKey();

            //int轉列舉<若不存在將直接輸出原始值>
            //宣告p66_Int等於5
            int p66_Int = 5;
            //強制將5轉為列舉中第5個值給p66_Open_1
            QQState p66_Open_1 = (QQState)p66_Int;
            Console.WriteLine($"int轉列舉  {p66_Open_1}");
            Console.ReadKey();

            //string轉列舉<若不存在將當作異常>
            string p66_string = "5";
            //調用Parse這個方法，將字串轉為對應的列舉類型
            //Enum.Parse的第一個參數，寫typeof判斷要轉哪一個enum的類型
            //Enum.Parse的第二個參數，要轉換的字串
            //一定要進行宣告，將列舉值拿出來給p66_Open_2
            //(轉換的列舉類型)Enum.Parse(typeof(要轉換的列舉類型),要轉換的字串)
            QQState p66_Open_2 = (QQState)Enum.Parse(typeof(QQState), p66_string);
            Console.WriteLine($"字串轉為列舉值  {p66_Open_2}");
            Console.ReadKey();

            //練習 提供用戶選擇狀態，接收後，將輸入的類型轉換成列舉類型，並印出
            Console.WriteLine("請輸入狀態 Online、OffLine、Leave、Busy、CallMe,");
            string p66_test = Console.ReadLine();

            QQState p66_test_enum = (QQState)Enum.Parse(typeof(QQState), p66_test);
            int p66_test_int = (int)p66_test_enum;
            Console.WriteLine($"用戶輸入值，轉換成列舉值  {p66_test_enum} 再轉int {p66_test_int}");
            Console.ReadLine();
        }

        /// <summary>
        /// P67 結構
        /// </summary>
        static void P67()
        {
            Person sanby;
            sanby._p67_name = "Sanby";
            sanby._p67_age = 28;
            sanby._p67_gender = Gender.女;

            Console.WriteLine($"名字{sanby._p67_name}年齡{sanby._p67_age}性別{sanby._p67_gender}");
            Console.ReadKey();

            //練習-1 (三原色調色器的概念)
            //定義一個結構叫MyColor，有三個成員，分別是int類型的red,green,blue
            //宣告一個 MyColor類型的變量，對其成員賦值，讓Mycolor是紅色

            MyColor p67_color;
            p67_color._p67_blue = 0;
            p67_color._p67_green = 0;
            p67_color._p67_red = 255;
            Console.WriteLine($"三原色-> 紅 {p67_color._p67_red}、綠 {p67_color._p67_green}、藍{p67_color._p67_blue}");
            Console.ReadKey();

            //練習-2
            //定義一個結構Person，有三個成員，為姓名、性別、年齡，性別為列舉類型
            //宣告兩的變量，小三 18歲 女生、小四 20歲 男生

            Person l3;
            l3._p67_gender = Gender.女;
            l3._p67_age = 18;
            l3._p67_name = "小三";

            Person l4;
            l4._p67_gender = Gender.男;
            l4._p67_age = 20;
            l4._p67_name = "小四";

            Console.WriteLine($"第一位姓名{l3._p67_name}、年齡{l3._p67_age}、性別{l3._p67_gender}");
            Console.WriteLine($"第二位姓名{l4._p67_name}、年齡{l4._p67_age}、性別{l4._p67_gender}");
            Console.ReadKey();

        }

        /// <summary>
        /// P68 陣列
        /// </summary>
        static void P68()
        {
            //宣告陣列
            //陣列的類型[] 陣列名稱 = new 陣列類型 [陣列長度];
            int[] p68_nums = new int[10];
            int[] p68_nums2 = { 1, 2, 3, 4, 5, 6 };

            //執行時會報異常，因為超出指定的長度
            //p68_nums[10] = 11;

            //賦值後，列印出來
            //賦值方式，第一個值給0、第2個給1...依此類推
            for (int i = 0; i < p68_nums.Length; i++)
            {
                p68_nums[i] = i;
                Console.WriteLine(p68_nums[i]);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// P69 陣列練習
        /// </summary>
        static void P69()
        {
            //練習:從一個整數陣列，取出最大/小值、總和、平均
            //宣告 int類型變數，並隨意的賦初值

            int[] p69_numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int p69_max = p69_numbers[0]; //或是可以指定int區間的最小值 int.MinValue
            int p69_min = p69_numbers[0]; //或是可以指定int區間的最大值 int.MaxValue
            int p69_sum = 0;
            for (int i = 0; i < p69_numbers.Length; i++)
            {
                if (p69_numbers[i] > p69_max)
                {
                    p69_max = p69_numbers[i];
                }
                if (p69_numbers[i] < p69_min)
                {
                    p69_min = p69_numbers[i];
                }

                p69_sum += p69_numbers[i];
            }

            Console.WriteLine($"最大值{p69_max}、最小值{p69_min}、平均值{p69_sum / p69_numbers.Length}、總和{p69_sum}");
            Console.ReadKey();
        }

        /// <summary>
        /// P70 陣列練習
        /// </summary>
        static void P70()
        {
            //陣列都是存入人名，分割成小明、阿花、老王
            //印出結果為 ->小明|阿花|老王
            string[] p70_names = { "小明", "阿花", "老王" };

            for (int i = 0; i < p70_names.Length; i++)
            {
                Console.Write($"{p70_names[i]}");
                if (p70_names.Length != i + 1)
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine("");
            Console.ReadKey();

            //老師的寫法
            string p70_str = null;
            for (int i = 0; i < p70_names.Length - 1; i++)
            {
                p70_str += p70_names[i] + "|";
            }
            Console.WriteLine($"{p70_str}{p70_names[p70_names.Length - 1]}");
            Console.ReadKey();

            //將一個整數數字的陣列
            //如果是正數，將數值+1
            //如果是負數，將數值-1
            //如果是0，不變
            int[] p70_ints = { 10, 20, 30, 0, -40, -50, -60 };
            string p70_ints_string = null;

            for (int i = 0; i < p70_ints.Length; i++)
            {
                if (p70_ints[i] > 0)
                {
                    p70_ints[i] += 1;
                }
                else if (p70_ints[i] < 0)
                {
                    p70_ints[i] -= 1;
                }

                p70_ints_string += p70_ints[i] + " ";
            }
            Console.WriteLine($"{p70_ints_string}");
            Console.ReadKey();

            //將字串陣列的元素進行順序反轉
            string[] p70_strings = { "我", "是", "好人" };

            for (int i = 0; i < p70_strings.Length / 2; i++)
            {
                string temp = p70_strings[i];
                p70_strings[i] = p70_strings[p70_strings.LongLength - 1 - i];
                p70_strings[p70_strings.LongLength - 1 - i] = temp;
            }

            for (int i = 0; i < p70_strings.Length; i++)
            {
                Console.WriteLine($"{p70_strings[i]}");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// P71泡沫排序
        /// </summary> 
        static void P71()
        {
            int[] p71_ints = { 12, 11, 10, 9, 8, 7, 6, 5 };
            //for (int i = 0; i < p71_ints.Length-1; i++)
            //{
            //    for (int j =0; j < p71_ints.Length-1-i; j++)
            //    {
            //        if (p71_ints[j] > p71_ints[j+1]) //前面的值大於後面的值 #升冪
            //        {
            //            int temp = p71_ints[j];
            //            p71_ints[j] = p71_ints[j + 1];
            //            p71_ints[j + 1] = temp;
            //        }
            //    }
            //}
            Array.Sort(p71_ints);  //Sort升冪 Reverse倒牌
            for (int i = 0; i < p71_ints.Length; i++)
            {
                Console.Write($"{p71_ints[i]} ");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// P72 方法的使用方式
        /// 類別名稱.方法名稱
        /// </summary>
        static void P72()
        {
            int p71_1 = 0;
            int p72_2 = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.WriteLine("請輸入第一個整數");
                    p71_1 = Convert.ToInt32(Console.ReadLine());
                    //catch
                    //{
                    //    Console.WriteLine("輸入錯誤，請重新輸入");
                    //}
                    Console.WriteLine("請輸入第二個整數");
                    p72_2 = Convert.ToInt32(Console.ReadLine());
                    retry = false;
                }
                catch
                {
                    Console.WriteLine("輸入錯誤，請重新輸入");
                }
            }
            int p72_max = Program.GetMax(p71_1, p72_2);
            Console.WriteLine($"最大數是{p72_max}");
            Console.ReadKey();
        }

        /// <summary>
        /// P72 練習方法:計算兩整數最大值，並返回
        /// </summary>
        /// <param name="n1">第一個整數</param>
        /// <param name="n2">第二個整數</param>
        /// <returns>最大整數</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }
}
