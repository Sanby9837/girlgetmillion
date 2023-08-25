using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P158_Store
{
    internal class SuperMarket
    {
        StoreHouse ck = new StoreHouse();

        /// <summary>
        /// 新增物件後，順便進貨
        /// </summary>
        public SuperMarket()
        {
            ck.Input("Acer", 1000);
            ck.Input("Samsung", 2000);
            ck.Input("Salt", 1000);
            ck.Input("Banana", 2000);
        }

        /// <summary>
        /// 購買流程
        /// </summary>
        public void AskBuying()
        {
            Console.WriteLine("請問您需要什麼呢?");
            Console.WriteLine("我們有Acer,Samsung,Salt,Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要幾個呢?");
            int count = Convert.ToInt32(Console.ReadLine());

            //取貨
            Product[] pros = ck.Output(strType, count);

            //while (true)
            //{
            //    Console.WriteLine("請問還有需要買什麼東西嗎? 請輸入y或n");
            //    string yn = Console.ReadLine();
            //    while (yn != "y" && yn != "n")
            //    {
            //        Console.WriteLine("請輸入y或n");
            //        yn = Console.ReadLine();
            //    }
            //    if (yn == "y")
            //    {
            //        Console.WriteLine("請問還需要Acer,Samsung,Salt,Banana  哪一項呢?");
            //        strType = Console.ReadLine();
            //        Console.WriteLine("您需要幾個呢?");
            //        count = Convert.ToInt32(Console.ReadLine());
            //        //取貨
            //        pros = ck.Output(strType, count);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //算錢
            double price = GetMoney(pros);
            Console.WriteLine($"您需要支付{price}元");
            Console.WriteLine($"請輸入打折方式 1. Normal 2. 8折 3. 買千送百");
            string intput = Console.ReadLine();

            //根據輸入的資料，獲得一個打折的對象
            Discount dis = GetDiscount(intput);
            double totalMoney = dis.GetTotalMoney(price);
            Console.WriteLine($"打折後，應付{totalMoney}");

            Console.WriteLine($"您好，購物明細請查收");
            foreach (var item in pros)
            {
                Console.WriteLine($"購買物品：{item.Name}  單價：{item.Price} ID：{item.ID}");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 根據貨物計算金額
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>
        public double GetMoney(Product[] pros)
        {
            double total = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                total += pros[i].Price;
            }
            return total;
        }

        /// <summary>
        /// 確認折扣數
        /// </summary>
        /// <param name="intput"></param>
        /// <returns>折扣的分類</returns>
        public Discount GetDiscount(string intput)
        {
            Discount dis = null;
            switch (intput)
            {
                case "1": dis = new DiscountNormal(); break;
                case "2": dis = new DiscountRate(0.8); break;
                case "3": dis = new DiscountMN(1000, 100); break;
            }
            return dis;
        }

        /// <summary>
        /// 顯示物品
        /// </summary>
        public void ShowPros()
        {
            ck.ShowPros();
        }
    }
}
