using System;
using System.Collections.Generic;
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
        /// P22 算數運算符 中文90、數學80、英文67，求平均分數
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
        /// P23 T-shirt 一件35，褲子一件120，請設計讓使用者自已輸入購買件數(3;2、345;303.6)，且試算價格，並顯示給予折扣8.8折後價格
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
    }
}
