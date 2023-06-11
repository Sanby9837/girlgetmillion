using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("go to ???");
            string go = Console.ReadLine();


            switch (go)
            {
                case "19":
                case "20":
                    P19And20();
                    break;
                case "21":
                    P21();
                    break;
                case "22":
                    P22();
                    break;
                case "23":
                    P23();
                    break;
                case "24":
                    P24();
                    break;
                case "26":
                    P26();
                    break;
                case "28":
                    P28();
                    break;
                case "29":
                    P29();
                    break;
                case "30":
                    P30();
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// P19&20.怎麼讓使用者自己賦值
        /// </summary>
        static void P19And20()
        {
            Console.WriteLine("請輸入您的姓名");
            string name = Console.ReadLine();  //Console.ReadLine 可以input資料
            Console.WriteLine("請輸入您的性別");
            string gender = Console.ReadLine();
            Console.WriteLine("請輸入您的年齡");
            string age = Console.ReadLine();

            Console.WriteLine("您好{0},您的年齡是{1}是個{2}", name, age, gender);
            Console.WriteLine($"您好{name},您的年齡是{age}是個{gender}");
            Console.ReadKey();
        }

        /// <summary>
        /// P21 轉義符跳脫字元
        /// </summary>
        static void P21()
        {
            // \n 換行
            // \b 刪除前一個字元(放在最前面跟最後面沒有效果)
            // \f 換頁
            // \t 水平tab
            // \v 垂直tab
            Console.WriteLine("今天天氣晴朗\n很適合出去玩");
            Console.ReadKey();
        }

        /// <summary>
        /// P22 算數運算符
        /// 中文90、數學80、英文67，求平均分數
        /// 計算半徑為5的圓，該面積和周長為何 pi=3.14
        /// </summary>
        static void P22()
        {
            int chinese = 90;
            int math = 80;
            int english = 67;
            Console.WriteLine((chinese + math + english) / 3);
            Console.WriteLine($"平均成績{(chinese + math + english) / 3}");
            Console.ReadKey();

            int r = 5;
            double area = 3.14 * r * r;
            double perismeter = 2 * 3.14 * r;
            Console.WriteLine($"面積={area}周長={perismeter}");
            Console.ReadKey();
        }

        /// <summary>
        /// P23  算數運算符練習
        /// T-shirt 一件35，褲子一件120，請設計讓使用者自已輸入購買件數(3;2、345;303.6)，且試算價格，並顯示給予折扣8.8折後價格
        /// </summary>
        static void P23()
        {
            // 成本
            int shirtPrice = 35;
            int pantPrice = 120;

            // 銷售折扣
            decimal discount = 0.88m;
            // 先把輸入的文字接起來
            Console.WriteLine("您要買幾件衣服：");
            string shirtCountString = Console.ReadLine();
            Console.WriteLine("您要買幾件褲子：");
            string pantCountString = Console.ReadLine();

            // 轉換成數字
            int shirtCount = Convert.ToInt32(shirtCountString);
            int pantCount = Convert.ToInt32(pantCountString);

            // 計算價格
            int pay = shirtPrice * shirtCount + pantPrice * pantCount;

            // 計算折扣後的價格
            decimal payDiscount = pay * discount;

            // 印出明細
            Console.WriteLine($"您購買的原價是：{pay}，目前的的折扣為：{discount}，折扣後價格為({payDiscount})");
            Console.WriteLine($"您購買的原價是{shirtPrice * shirtCount + pantPrice * pantCount}，折扣後價格為{(shirtPrice * shirtCount + pantPrice * pantCount) * 0.88} ");
            Console.ReadKey();
        }

        /// <summary>
        /// P23 類型轉換
        /// </summary>
        static void P24()
        {
            int n24_1 = 10;
            int n24_2 = 3;
            // 這樣d24的類型還是int整數
            double d24 = n24_1 / n24_2;
            Console.WriteLine($"d24的值是{d24}");
            Console.ReadKey();

            int n24_3 = 5;
            double n24_4 = 2;
            // 這樣d24_1的類型會變更為double小數類型
            double d24_1 = n24_3 / n24_4;
            Console.WriteLine($"d24_1的值是{d24_1}");
            Console.ReadKey();

            int n24_5 = 10;
            int n24_6 = 3;
            // 這樣d24_2的類型，因為*1.0，故也可以變為double小數類型
            double d24_2 = n24_5 * 1.0 / n24_6;
            // 新的寫法，$" 字串+佔位符{}中間可以直接放值 冒號後面放表達方式 "
            Console.WriteLine($"d24_2的值{d24_2:0.00}");
            // 佔位符{}中間放第幾的位置的文字 冒號後面放表達方式
            Console.WriteLine("d24_2的值有小術後兩位的結果{0:0.00}", d24_2);
            Console.ReadKey();
        }

        /// <summary>
        /// P26
        /// 1.輸入框輸入幾天後，顯示幾周幾天
        /// 2.輸入框輸入秒數，顯示幾天幾時幾分幾秒
        /// </summary>
        static void P26()
        {
            //1.輸入框輸入幾天後，顯示幾周幾天
            Console.WriteLine("請入計算天數，幫您換算為 X 周 X 天");
            string dayPutString = Console.ReadLine();

            //將字串轉為數值
            int dayPut = Convert.ToInt32(dayPutString);

            //將天數換成幾周幾天
            int weekResult = dayPut / 7;
            int dayResult = dayPut % 7;

            //印出來
            Console.WriteLine($"結果是{weekResult}周{dayResult}天");
            Console.ReadKey();

            // 2.輸入框輸入秒數，顯示幾天幾時幾分幾秒，並將字串轉為數值
            Console.WriteLine("請入計算秒數，幫您換算為X天X時X分X秒");
            int secPut = Convert.ToInt32(Console.ReadLine());

            //將秒數換成幾天，一天有84600秒
            int days = secPut / 86400;

            //剩餘的秒數
            int secs = secPut % 86400;

            //將秒數換成幾小時，一小時3600秒
            int hours = secs / 3600;
            secs = secs % 3600;

            //將秒數換成幾分鐘，一分鐘60秒
            int mins = secs / 60;
            secs = secs % 60;

            //印出來
            Console.WriteLine($"結果是{days}天{hours}時{mins}分{secs}秒");
            Console.ReadKey();


        }

        /// <summary>
        /// P28 加加使用方式
        /// 1.變數++
        /// </summary>
        static void P28()
        {
            int numberP28_1 = 10;
            int resultP28_1 = 10 + numberP28_1++;
            int resultP28_3 = 10 + numberP28_1;

            Console.WriteLine($"我是單純++的值{resultP28_3}");
            Console.WriteLine($"我是單純++的值{numberP28_1}");
            Console.ReadKey();

            Console.WriteLine($"P28_1 =10 + numberP28_1++ ={resultP28_1}");
            Console.ReadKey();

            int numberP28_2 = 10;
            int resultP28_2 = 10 + ++numberP28_2;
            Console.WriteLine($"P28_2 =10 + ++numberP28_2 ={resultP28_2}");
            Console.ReadKey();
        }

        /// <summary>
        /// 關係運算符(布林值)
        /// 邏輯運算符
        /// </summary>
        static void P29()
        {
            // and 全部都是t就是t
            // & 
            // &&
            var sanby = 27;
            var woody = 32;
            bool P29_1 = sanby > 30;
            bool P29_2 = sanby > 30 & woody > 30;
            bool P29_3 = woody > 30 && sanby > 30;
            bool P29_4 = sanby > 30 && woody > 30;
            Console.WriteLine($"P29_1  {P29_1},P29_2  {P29_2},P29_3  {P29_3},P29_4  {P29_4}");
            Console.ReadKey();


            // or 任一
            // |
            // ||
            bool P29_5 = woody > 30 || sanby > 30;
            bool P29_6 = sanby > 30 || woody > 30;

            Console.WriteLine($"P29_5  {P29_5},P29_6  {P29_6}");
            Console.ReadKey();


            // 相反
            // !
            bool P29_7 = !P29_5;

            if (!P29_7)
            {
                Console.WriteLine($"P29_7:::{P29_7}");
            }
            Console.ReadKey();

            //關係運算符 > < >= <= == !=(不等於)
            bool b_P29 = 1500 > 1;
            Console.WriteLine(b_P29);
            Console.ReadKey(true);

            //邏輯運算符 && || !
            bool b_P29_1 = 1500 > 1;
            Console.WriteLine(b_P29_1);
            Console.ReadKey(true);
        }
        
        /// <summary>
        /// 閏年判斷小工具
        /// </summary>
        static void P30()
        {
            //1.輸入框輸入年份，並將字串轉為數值
            Console.WriteLine("請入判斷年份");
            int P30_year = Convert.ToInt32(Console.ReadLine());

            //閏年的判斷邏輯
            //年份可以被400整除，或年份可以被4整除但不能被100整除
            bool P30_chcek = ( P30_year % 400 == 0 ) || ( P30_year % 4 == 0 && P30_year % 100 != 0);

            //印出來
            Console.WriteLine($"結果是{P30_chcek}");
            Console.ReadKey();
        }
    }
}
