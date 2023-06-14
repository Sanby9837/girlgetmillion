using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("go to ???");
            string go = Console.ReadLine();


            switch (go)
            {
                case "31":
                    P31();
                    break;
                case "32":
                    P32();
                    break;
                case "33":
                    P33();
                    break;
                case "34":
                    P34();
                    break;
                case "35":
                    P35();
                    break;
                case "37":
                    P37();
                    break;
                case "38":
                    P38();
                    break;
                case "40":
                    P40();
                    break;
                case "41":
                    P41();
                    break;
                case "42":
                    P42();
                    break;
                case "43":
                    P43();
                    break;
                case "44":
                    P44();
                    break;
                case "45":
                    P45();
                    break;
                case "47":
                    P47();
                    break;
                case "48":
                    P48();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// P31 if語法
        /// </summary>
        static void P31()
        {
            //如果跪鍵盤時間大於60分鐘，就可以不用煮飯
            Console.WriteLine("請說明跪算盤多久了");
            int p31_Mins = Convert.ToInt32(Console.ReadLine());

            //如果判斷式為等於ture進方法處理，則可直接寫判斷式
            //如果判斷式為希望等於false，判斷式最後請加上 ==false
            if (p31_Mins >= 60)
            {
                Console.WriteLine("恭喜不用煮飯");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("請乖乖煮飯");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// P32 練習if語法(一種情況)
        /// </summary>
        static void P32()
        {
            //如果老蘇成績滿足以下任一條件，則獎勵100元
            //中文大於90且音樂大於80
            //中文=100且音樂大於70
            Console.WriteLine("請輸入您的中文成績");
            int p32_Chinese = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("請輸入您的音樂成績");
            int p32_Music = Convert.ToInt32(Console.ReadLine());

            bool p32_Check_1 = p32_Chinese >= 90 && p32_Music >= 80;
            bool p32_Check_2 = p32_Chinese == 100 && p32_Music >= 70;

            if (p32_Check_1 || p32_Check_2)
            {
                Console.WriteLine("恭喜獲得100元");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("抱歉! 成績不符，下次請加油");
                Console.ReadKey();
            }


            //請輸入帳號密碼，若帳號為admin，密碼為mypass，顯示登入成功
            Console.WriteLine("請輸入帳號");
            string p32_LoginName = Console.ReadLine();

            Console.WriteLine("請輸入密碼");
            string p32_LoginPass = Console.ReadLine();

            if (p32_LoginName == "admin" && p32_LoginPass == "mypass")
            {
                Console.WriteLine("登入成功");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("登入失敗");
                Console.ReadKey();

            }
        }

        /// <summary>
        /// P33 if-else語法 (兩種情況)
        /// </summary>
        static void P33()
        {
            //如果考試成績大於90(含)，獎勵100元，否則請罰跪
            Console.WriteLine("請輸入成績");
            int p33_Score = Convert.ToInt32(Console.ReadLine());

            if (p33_Score >= 90)
            {
                Console.WriteLine("恭喜獲得100大洋");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("請跪算盤");
                Console.ReadKey();
            }

        }

        /// <summary>
        /// P34 if-else-if 用來處理多條件、區間性判斷 (多種情況)
        /// </summary>
        static void P34()
        {
            //對於考試成績進行分等
            Console.WriteLine("請輸入分等成績試算");
            int p34_Score = Convert.ToInt32(Console.ReadLine());

            //只有if的寫法
            //if (p34_Score >= 90)
            //{
            //    Console.WriteLine("A等");
            //}
            //if (p34_Score >= 80 && p34_Score < 90)
            //{
            //    Console.WriteLine("B等");
            //}
            //if (p34_Score >= 70 && p34_Score < 80)
            //{
            //    Console.WriteLine("C等");
            //}
            //if (p34_Score >= 60 && p34_Score < 70)
            //{
            //    Console.WriteLine("D等");
            //}
            //if (p34_Score < 60)
            //{
            //    Console.WriteLine("E等");
            //}

            if (p34_Score >= 90)
            {
                Console.WriteLine("A等");
            }
            else if (p34_Score >= 80)
            {
                Console.WriteLine("B等");
            }
            else if (p34_Score >= 70)
            {
                Console.WriteLine("C等");
            }
            else if (p34_Score >= 60)
            {
                Console.WriteLine("D等");
            }
            else
            {
                Console.WriteLine("E等");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// P35 if-else-if練習 三道練習題
        /// </summary>
        /// <returns></returns>
        static void P35()
        {
            //輸入密碼，如果密碼為8888，提示正確；
            //錯誤則重新輸入，如果密碼為8888提示正確，否則提示錯誤，並結束

            Console.WriteLine("請輸入密碼");
            string p35_check = Console.ReadLine();

            if (p35_check == "8888")
            {
                Console.WriteLine("密碼正確");
            }
            else
            {
                Console.WriteLine("密碼錯誤，請重新輸入");
                p35_check = Console.ReadLine();

                if (p35_check == "8888")
                {
                    Console.WriteLine("密碼已正確");
                }
                else
                {
                    Console.WriteLine("密碼錯誤，再見");
                }
            }
            Console.ReadKey();

            //輸入帳號密碼，如果帳號是admin且密碼為8888，提示正確；
            //帳號錯誤提示帳號不存在，帳號是admin且密碼錯誤提示密碼錯誤

            Console.WriteLine("請輸入帳號");
            string p35_LoginName = Console.ReadLine();
            Console.WriteLine("請輸入密碼");
            string p35_LoginPass = Console.ReadLine();

            //第一種情況帳號密碼都正確
            if (p35_LoginName == "admin" && p35_LoginPass == "8888")
            {
                Console.WriteLine("登入成功");
            }
            //第二種情況，基於第一個情況符合，故當第二個情況如果寫帳號正確，那密碼一定是不正確，所以才可以符合第二個情境
            else if (p35_LoginName == "admin")
            {
                Console.WriteLine("密碼錯誤");
            }
            //第三種情況，均錯誤
            else
            {
                Console.WriteLine("帳號、密碼錯誤");
            }
            Console.ReadKey();

            //輸入年紀，大於等於18，提示可查看
            //小於10歲，提示禁止查看
            //10~17請輸入y/n確認是否查看
            //y請查看，n退出，不查看

            Console.WriteLine("請輸入您的年齡");
            int p35_Age = Convert.ToInt32(Console.ReadLine());

            if (p35_Age >= 18)
            {
                Console.WriteLine("已滿18歲，請查看");
            }
            else if (p35_Age < 10)
            {
                Console.WriteLine("未滿10歲禁止查看");
            }
            else
            {
                Console.WriteLine("10~17歲，請輸入y/n，以確認是否觀看");
                string p35_AgeCheck = Console.ReadLine();
                if (p35_AgeCheck == "y")
                {
                    Console.WriteLine("請查看");
                }
                else
                {
                    Console.WriteLine("退出，不觀看");
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// P37 異常捕獲 try-catch
        /// </summary>
        static void P37()
        {
            //變量作用域：聲明變量的區域內才可使用
            int p37_Number = 0;

            //方法一
            //Console.WriteLine("請輸入數字");
            //try
            //{
            //    p37_Number = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"輸入的數值為 {p37_Number * 2}");
            //}
            //catch
            //{
            //    Console.Write("輸入的內容無法轉換為數字");
            //}
            //Console.ReadKey();

            //方法二
            bool p37_Check = true;
            Console.WriteLine("請輸入數字");
            try
            {
                p37_Number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Write("輸入的內容無法轉換為數字");
                p37_Check = false;
            }

            if (p37_Check)
            {
                Console.WriteLine($"輸入的數值為 {p37_Number * 2}");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// P38 switch-case多條件定值判斷
        /// </summary>
        static void P38()
        {
            //執行到switch處，先算出()中變量或表達式，將這個值跟每一個case配對
            //配對成功後，執行case中的程序，遇到break結束。
            //有default就執行default，無就跳出。

            //練習題 預設薪資30000，輸入kpi評定，A級+2000、B級+1000、C級不加薪、D級-300、E級-500

            double p38_salary = 30000;
            Console.WriteLine("請輸入考核等級");
            string p38_level = Console.ReadLine();
            bool p38_check = true;
            switch (p38_level)
            {
                case "A":
                    p38_salary += 2000;
                    break;
                case "B":
                    p38_salary += 1000;
                    break;
                case "C":
                    break;
                case "D":
                    p38_salary -= 300;
                    break;
                case "E":
                    p38_salary -= 500;
                    break;
                default:
                    Console.WriteLine("輸入錯誤");
                    p38_check = false;
                    break;
            }
            if (p38_check)
            {
                Console.WriteLine($"調整後薪資{p38_salary}");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// P39 switch-case練習 判斷閏年
        /// </summary>
        static void P40()
        {
            //閏年判斷小工具
            //1.輸入框輸入年份、月份，輸出該月份天數
            Console.WriteLine("請入判斷年份");
            try
            {
                int p40_year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("請入判斷月份");
                try
                {
                    int p40_month = Convert.ToInt32(Console.ReadLine());

                    //閏年的判斷邏輯
                    //年份可以被400整除，或年份可以被4整除但不能被100整除
                    bool p40_chcek = (p40_year % 400 == 0) || (p40_year % 4 == 0 && p40_year % 100 != 0);

                    switch (p40_month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            Console.WriteLine("31天");
                            break;

                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            Console.WriteLine("30天");
                            break;
                        case 2:
                            if (p40_chcek)
                            {
                                Console.WriteLine("28天");
                            }
                            else
                            {
                                Console.WriteLine("29天");
                            }
                            break;
                        default:
                            Console.WriteLine("輸入月份錯誤");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("輸入月份錯誤，退出中");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-------------------------------");
                Console.WriteLine(ex.Message.ToString());
                Console.WriteLine("輸入年份錯誤，退出中");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// P41 循環結構(while)
        /// </summary>
        static void P41()
        {
            //題目:向控制台打印10遍，下次考試一定要細心

            int p41_Counts = 0;
            while (p41_Counts < 10)
            {
                Console.WriteLine($"下次考試一定要細心{p41_Counts}");
                p41_Counts += 1;
            }
            Console.ReadKey();
        }

        /// <summary>
        /// P42 循環結構(while) 練習題
        /// </summary>
        static void P42()
        {
            //題目:求1加到100的合

            int p42_Counts = 1;
            int p42_Sum = 0;
            while (p42_Counts < 101)
            {
                p42_Sum = p42_Sum + p42_Counts++;
            }
            Console.WriteLine($"1到100的和{p42_Sum}");
            Console.ReadKey();

            //break:case中跳出執行序、跳出當前while循環
            //輸入帳號密碼，帳號admin、密碼8888顯示登入成功，若錯誤，當作失敗重新輸入
            //條件:帳號密碼符合
            //循環語法:輸入帳號密碼，判斷密碼是否正確

            string p42_LoginName = "";
            string p42_LoginPass = "";
            bool p42_LoginCheck = true;

            while (p42_LoginCheck)
            {
                Console.WriteLine("請輸入帳號");
                p42_LoginName = Console.ReadLine();
                Console.WriteLine("請輸入密碼");
                p42_LoginPass = Console.ReadLine();

                if (p42_LoginName == "admin" && p42_LoginPass == "8888")
                {
                    p42_LoginCheck = false;
                }
                else
                {
                    Console.WriteLine("登入失敗，請重新登入");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("登入成功");
            Console.ReadKey();

            //--------------------
            //老師寫的
            //string p42_LoginName_T = "";
            //string p42_LoginPass_T = "";

            //while (p42_LoginName_T != "admin" || p42_LoginPass_T != "8888")
            //{
            //    Console.WriteLine("請輸入帳號");
            //    p42_LoginName_T = Console.ReadLine();
            //    Console.WriteLine("請輸入密碼");
            //    p42_LoginPass_T = Console.ReadLine();
            //}
            //Console.WriteLine("登入成功");
            //Console.ReadKey();

        }

        /// <summary>
        /// P43 循環結構(while) 練習題-1
        /// </summary>
        static void P43()
        {
            //題目:輸入班級人數，依次輸入成績，計算平均成績、總成績
            //條件:輸入的人數到達正確數字
            //循環語法:輸入成績，並加總成績

            Console.WriteLine("請輸入班級人數");
            int p43_CountsPP = Convert.ToInt32(Console.ReadLine());
            int p43_CountsppCheck = 1;
            int p43_ScoreSum = 0;
            int p43_ScoreInput = 0;

            while (p43_CountsppCheck <= p43_CountsPP)
            {
                Console.WriteLine($"請輸入第{p43_CountsppCheck}位的成績");
                p43_ScoreInput = Convert.ToInt32(Console.ReadLine());  //可以直接在這邊宣告?
                p43_ScoreSum = p43_ScoreSum + p43_ScoreInput;
                p43_CountsppCheck++;
            }
            Console.WriteLine($"總人數{p43_CountsPP},總成績{p43_ScoreSum},平均成績{p43_ScoreSum / p43_CountsPP}");
            Console.ReadKey();


        }

        /// <summary>
        /// P44 循環結構(while) 練習題-2、3
        /// </summary>
        static void P44()
        {
            //詢問是否會做，
            //回答y可以放學，回答n 再講一遍，再次詢問是否會做
            //但如果講了10次還不會，就放學
            //條件:回答不會、或是累計10次以內都不會
            //循環語法:老師再講一次，並詢問是否會了

            int p44_CheckCounts = 1;
            bool p44_Chooese = true;

            while (p44_Chooese && p44_CheckCounts < 11)
            {
                Console.WriteLine($"老師講課中...{p44_CheckCounts}");
                Console.WriteLine("請問同學，學會了嗎?");
                string sp44_Chooese_ask = Console.ReadLine();

                if (sp44_Chooese_ask == "y")
                {
                    p44_Chooese = false;
                }
                else
                {
                    p44_CheckCounts++;
                }
            }
            Console.WriteLine("OK，放學囉!");
            Console.ReadKey();

            //目前是2006年，學校共有80,000人，每年增加25%
            //請問在第幾年可以達到200,000人?
            //條件:學生加總達20萬人時
            //循環語法:學生加總*1.25，年份+1

            int p44_Year = 2006;
            double p44_StudentCount = 80000;

            while (p44_StudentCount < 200000)
            {
                p44_StudentCount *= 1.25;
                p44_Year++;
            }
            Console.WriteLine($"第{p44_Year}學生達到{p44_StudentCount}人");
            Console.ReadKey();


            //提供輸入y或n，如果不是y或n就一直重新輸入
            //條件:判斷輸入的值是y或n
            //循環語法:輸入y or n 判斷

            string p44_checkYN = "";

            while (p44_checkYN != "y" && p44_checkYN != "n")
            {
                Console.WriteLine("請輸入y或n");
                p44_checkYN = Console.ReadLine();
            }
            Console.WriteLine($"輸入正確啦{p44_checkYN}");
            Console.ReadKey();
        }

        /// <summary>
        /// P45 循環結構(do while)
        /// </summary>
        static void P45()
        {
            //明天學生要上台演出，老師說要把演出歌曲重唱一遍
            //如果滿意學生可以回家。不然就再練習一次，直到滿意
            //條件:老師不滿意
            //循環語法:演出歌曲重唱

            //while 先判斷條件，再執行循環語法

            Console.WriteLine("WHILE    老師:請再將歌曲唱一遍");
            Console.ReadKey();
            string p45_Kpi_check = "n";

            while (p45_Kpi_check != "y")
            {
                Console.WriteLine("學生唱歌中...");
                Console.ReadKey();
                Console.WriteLine("學生:老師請問滿意嗎?");
                p45_Kpi_check = Console.ReadLine();
            }
            Console.WriteLine("老師:請學生放學囉");
            Console.ReadKey();

            //do-while 先執行do的語法，再判斷do-while循環條件，成立->執行do的語法；不成立->退出do-while循環

            Console.WriteLine("DO-WHILE 老師:請再將歌曲唱一遍");
            string p45_goodYN = "n";
            do
            {
                Console.WriteLine("學生唱歌中...");
                Console.ReadKey();
                Console.WriteLine("學生:老師請問滿意嗎?");
                p45_goodYN = Console.ReadLine();

            } while (p45_goodYN != "y");

            Console.WriteLine("老師:請學生放學囉");
            Console.ReadKey();

        }

        /// <summary>
        /// P47 do while複習
        /// </summary>
        static void P47()
        {
            //不斷要求輸入數字，然後顯示數字的兩倍。
            //如果輸入q則結束程序
            //條件:輸入值不等於q
            //循環邏輯:輸入字串，判斷字串不是q，則顯示字串數字*2，判斷字串是q，把A改q
            //最後顯示:輸入值

            string p47_Inputq = "";
            do
            {
                Console.WriteLine("請輸入數字或輸入q結束");
                p47_Inputq = Console.ReadLine();

                if (p47_Inputq != "q")
                {
                    try
                    {
                        int p47_InputNumber = Convert.ToInt32(p47_Inputq);
                        Console.WriteLine($"{p47_Inputq}的兩倍是{p47_InputNumber * 2}");
                    }
                    catch
                    {
                        Console.WriteLine("輸入錯誤");
                    }
                }
                else
                {
                    Console.WriteLine("輸入正確，退出");
                }
            }
            while (p47_Inputq != "q");
            Console.ReadKey();

            //------------------------------老師寫的
            //while (p47_Inputq != "q")
            //{

            //    Console.WriteLine("請輸入數字或輸入q結束");
            //    p47_Inputq = Console.ReadLine();
            //    if (p47_Inputq != "q")
            //    {
            //        try
            //        {
            //            int p47_InputNumber = Convert.ToInt32(p47_Inputq);
            //            Console.WriteLine($"{p47_Inputq}的兩倍是{p47_InputNumber * 2}");
            //        }
            //        catch
            //        {
            //            Console.WriteLine("輸入錯誤，請重新輸入");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("輸入正確，退出");
            //    }
            //}
            //Console.ReadKey();

            //不斷要求輸入數字(假定輸入的值都不會有錯誤)，
            //如果輸入end顯示剛剛輸入的數字中最大值，然後結束程序
            //條件:輸入值不等於end
            //循環邏輯:輸入字串，判斷字串不是end，字串轉數值如果>較大數值，將字串更新為最大數值
            //最後顯示:最大數值、輸入值

            string p47_Input = "";
            int p47_max = 0;

            while (p47_Input !="end")
            {
                Console.WriteLine("請輸入數字或end結束");
                p47_Input = Console.ReadLine();

                if (p47_Input != "end" )
                {
                    try
                    {
                        int p47_Int= Convert.ToInt32(p47_Input);
                        if (p47_Int > p47_max)
                        {
                            p47_max = p47_Int;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("輸入錯誤");
                    }
                }
                else //=end
                {
                    Console.WriteLine($"最大值是{p47_max}");
                }
            }
            Console.ReadKey();

        }

        /// <summary>
        /// P48 程序偵錯
        /// </summary>
        static void P48()
        {
            //1.寫完一段程序，想確認程序執行過程
            //2.當完成程序，發現未依照想像的方式運行
            //偵錯方式
            //1. F11 逐語句偵錯
            //2. F10 逐過程偵錯
            //3. 斷點偵錯
        }
    }
}

