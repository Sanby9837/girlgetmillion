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
    public enum QQState
    {
        Online = 3,
        OffLine,
        Leave,
        Busy,   
        CallMe,
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
        /// 
        /// </summary>
        static void P67()
        {

        }

    }
}
