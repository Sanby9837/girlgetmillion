using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P90FlyOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameShow();
            Console.ReadKey();
        }

        /// <summary>
        /// 使用靜態int陣列來宣告地圖
        /// </summary>
        public static int[] Maps = new int [100]; 

        /// <summary>
        /// 遊戲一開始的固定標題
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(^ρ^)/  Hello，Welcome Sanby's Fly Out");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************************************");
        }
    }
}
