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
            Console.WriteLine("請輸入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] =="")
            {
                Console.WriteLine("姓名不得為空，請重新輸入");
                PlayerNames[0] = Console.ReadLine();
            }

            Console.WriteLine("請輸入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1] == "" || PlayerNames[0] == PlayerNames[1])
            {
                if (PlayerNames[1]== "")
                {
                    Console.WriteLine("姓名不得為空，請重新輸入");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("姓名不得與玩家A相同，請重新輸入");
                    PlayerNames[1] = Console.ReadLine();
                }
            }


            InitailMaps();
            DrawMaps();
            Console.ReadKey();
        }

        /// <summary>
        /// 使用靜態int陣列來宣告地圖
        /// </summary>
        static int[] Maps = new int[100];

        /// <summary>
        /// 使用靜態int陣列來宣告兩玩家位置
        /// </summary>
        static int[] PlayerPos = new int[2];

        /// <summary>
        /// 使用靜態string陣列來宣告兩玩家姓名
        /// </summary>
        static string[] PlayerNames = new string[2];

        /// <summary>
        /// 遊戲一開始的固定標題
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("************************************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************************************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       (^ρ^)/  Hello，Welcome Sanby's Fly Out");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************************************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("************************************************************");
        }

        /// <summary>
        /// 初始化地圖
        /// </summary>
        public static void InitailMaps()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 }; //幸運輪盤
            //將幸運輪盤的陣列數組轉為index(整數)，再將Maps對應位置的數字改為1
            for (int i = 0; i < luckyturn.Length; i++)
            {
                int index = luckyturn[i];
                Maps[index] = 1;
            }

            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 }; //地雷
            for (int i = 0; i < landMine.Length; i++)
            {
                int index = landMine[i];
                Maps[index] = 2;
            }

            int[] pause = { 9, 27, 60, 93 }; //暫停
            for (int i = 0; i < pause.Length; i++)
            {
                int index = pause[i];
                Maps[index] = 3;
            }

            int[] timeTurn1 = { 20, 25, 45, 63, 72, 88, 90 }; //時空隧道
            for (int i = 0; i < timeTurn1.Length; i++)
            {
                int index = timeTurn1[i];
                Maps[index] = 4;
            }
        }

        /// <summary>
        /// 畫地圖
        /// </summary>
        public static void DrawMaps()
        {
            //第一行(0~29)
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawMapsFix(i));   
            }
            
            //換行
            Console.WriteLine();
            
            //第2~6行(0~28空白，第29格放30~34的路途)
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j <= 28; j++)
                {
                    Console.Write("　");
                }
                Console.Write(DrawMapsFix(i));
                Console.WriteLine();
            }

            //第7行(64往右畫到35)
            for (int i = 64; i > 34; i--)
            {
                Console.Write(DrawMapsFix(i));
            }
            
            //換行
            Console.WriteLine();

            //第8~12行(65~69)
            for (int i = 65; i < 70; i++)
            {
                Console.Write(DrawMapsFix(i));
                Console.WriteLine();
            }

            //第13行(70~99)
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawMapsFix(i));
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 畫圖方式
        /// </summary>
        /// <param name="i"></param>
        public static string DrawMapsFix(int i)
        {
            string str = "";
            //如果兩玩家位置相同，並且都在地圖上，顯示<>
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                str = "<>";
            }
            //第一個玩家，顯示A
            else if (PlayerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                str = "Ａ";
            }
            //第二個玩家，顯示B
            else if (PlayerPos[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                str = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "＿";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        str = "！";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "＊";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        str = "｜";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        str = "卍";
                        break;
                }//switch
            }//else
            return str;
        }
    }
}
