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
            #region 輸入玩家姓名
            Console.WriteLine("請輸入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("姓名不得為空，請重新輸入");
                PlayerNames[0] = Console.ReadLine();
            }

            Console.WriteLine("請輸入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1] == "" || PlayerNames[0] == PlayerNames[1])
            {
                if (PlayerNames[1] == "")
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
            #endregion

            //清除畫面資料
            Console.Clear();
            GameShow();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"第一名玩家姓名為{PlayerNames[0]}，地圖上會使用A顯示");
            Console.WriteLine($"第二名玩家姓名為{PlayerNames[1]}，地圖上會使用B顯示");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"｜幸運輪盤：1.交換位置 2.轟炸對方，後退6格");
            Console.WriteLine($"｜地雷：退6格");
            Console.WriteLine($"｜暫停：停一回合");
            Console.WriteLine($"｜時光隧道：進10格");
            InitailMaps();
            DrawMaps();

            //兩玩家沒有任一人在終點，就不停的玩遊戲
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                for (int i = 0; i < 2; i++)
                {
                    PlayGame(i);
                }
            }

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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("圖例----->  ！：幸運輪盤　＊：地雷　｜：暫停　卍：時光隧道");
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

        /// <summary>
        /// 玩遊戲
        /// </summary>
        public static void PlayGame(int player)
        {
            Console.WriteLine($"請玩家{PlayerNames[player]}點選任意鍵並投擲骰子");
            Console.ReadKey(true);
            Console.WriteLine($"{PlayerNames[player]}骰出了{4}");
            PlayerPos[player] += 4;
            Console.ReadKey(true);
            Console.WriteLine($"{PlayerNames[player]}開始飛行");
            Console.ReadKey(true);

            //執行玩家，可能會1.踩到另一名玩家2.踩到各種可能性
            if (PlayerPos[player] == PlayerPos[1 - player])
            {
                Console.WriteLine($"玩家{PlayerNames[player]}踩到另一名玩家位置，另一名玩家退後6格");
                PlayerPos[1 - player] -= 6;
                Console.ReadKey(true);
            }
            else
            {
                switch (Maps[PlayerPos[player]])
                {
                    case 0:
                        Console.WriteLine("呼~~   您安然無恙！");
                        break;
                    case 1:
                        Console.WriteLine($"{PlayerNames[player]}，您踩中【幸運輪盤】了！       可以有兩個選擇，輸入(1)將兩方交換位置或(2)對方退後六格");
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine($"{PlayerNames[player]}，您選擇(1)，故兩方位置交換");
                                int temp = PlayerPos[player];
                                PlayerPos[player] = PlayerPos[1 - player];
                                PlayerPos[1 - player] = temp;
                                Console.WriteLine("已交換完成，點選任意鍵繼續遊戲");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine($"{PlayerNames[player]}，您選擇(2)，轟炸對方，使其退後6格");
                                PlayerPos[1 - player] -= 6;
                                Console.WriteLine("轟炸完成，點選任意鍵繼續遊戲");
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("請輸入(1) 或 (2)");
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine($"{PlayerNames[player]}，您踩中【地雷】了！       退後6格(〒︿〒)");
                        PlayerPos[player] -= 6;
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.WriteLine($"{PlayerNames[player]}，您踩中【暫停】了！       下一回合不能移動(〒︿〒)");
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine($"{PlayerNames[player]}，您踩中【時光隧道】了！       前進10格(ﾉ>ω<)ﾉ");
                        PlayerPos[player] += 10;
                        Console.ReadKey(true);
                        break;
                }//switch
            }//if else

            Console.WriteLine($"{PlayerNames[player]}飛行完畢，任意點選以更新地圖");
            Console.ReadKey(true);
            Console.Clear();
            DrawMaps();
        }

    }
}
