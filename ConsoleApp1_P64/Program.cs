using System;
using System.Collections.Generic;
using System.Linq;
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
    public enum AppleStore
    {
        Online = 3,
        OffLine,
        Leave,
        Busy,
        TakeMe,
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
            //列舉可以直接跟int類型轉換
            //將列舉的值拿出來給p66_Open
            AppleStore p66_Open = AppleStore.OffLine;
            //強制將列舉轉為int給p66_OpenInt
            int p66_OpenInt = (int)p66_Open;
            Console.WriteLine($"列舉轉int{p66_OpenInt}");
            Console.ReadKey();

            //int也可以直接轉成列舉資料；若不存在將直接輸出原始值
            //宣告p66_Int等於5
            int p66_Int = 5;
            //強制將5轉為列舉中第5個值給p66_Open_1
            AppleStore p66_Open_1 = (AppleStore)p66_Int;
            Console.WriteLine($"int轉列舉{p66_Open_1}");
            Console.ReadKey();

            //列舉轉成字串
            string p66_OpenString = p66_Open.ToString();
            Console.WriteLine($"列舉轉字串{p66_OpenString}");
            Console.ReadKey();

            //將字串轉為列舉值
            string p66_string = "5";
            //調用Parse這個方法，將字串轉為對應的列舉類型
            //Enum.Parse的第一個參數，寫typeof判斷要轉哪一個enum的類型
            //Enum.Parse的第二個參數，要轉換的字串
            //一定要進行宣告，將列舉值拿出來給p66_Open_2
            AppleStore p66_Open_2 = (AppleStore)Enum.Parse(typeof(AppleStore), p66_string);
            Console.WriteLine($"子串轉為列舉值{p66_Open_2}");
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        static void P67()
        {

        }

    }
}
