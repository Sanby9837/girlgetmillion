using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("go to ???");
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
        /// P68 數組
        /// </summary>
        static void P68()
        {
            //宣告數組
            //數組的類型[] 數組名稱 = new 數組類型 [數組長度];
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
        /// P69 數組練習
        /// </summary>
        static void P69()
        {

        }
    }
}
