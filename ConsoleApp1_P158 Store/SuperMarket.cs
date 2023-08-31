using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
            ck.Input("acer", 1000);
            ck.Input("samsung", 2000);
            ck.Input("salt", 1000);
            ck.Input("banana", 2000);
        }

        /// <summary>
        /// 購買流程
        /// </summary>
        public void AskBuying()
        {
            Console.Write("我們有");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Acer,Samsung,Salt,Banana");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.WriteLine("請問您需要什麼呢?");
            string strType = Console.ReadLine().ToLower();
            while (strType != "acer" && strType != "samsung" && strType != "salt" && strType != "banana")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("請輸入Acer or Samsung or Salt or Banana");
                Console.ForegroundColor = ConsoleColor.White;
                strType = Console.ReadLine().ToLower();
                if (strType == "acer" || strType == "samsung" || strType == "salt" || strType == "banana")
                {
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("您需要幾個呢?");
            int count = Convert.ToInt32(Console.ReadLine());
            while (count <= 0)
            {
                Console.WriteLine("數量請大於0");
                count = Convert.ToInt32(Console.ReadLine());
                if (count > 0)
                {
                    break;
                }
            }

            //取貨
            Product[] pros = ck.Output(strType, count);

            //待優化--可以購買多個品項、缺貨處理方式
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

            if (pros.Length >= count)
            {
                double price = GetMoney(pros);
                //算錢
                Console.WriteLine($"您需要支付{price}元");
                Console.WriteLine($"請輸入打折方式 1.(Normal) 2.(8折) 3.(買千送百)");
                string intput = Console.ReadLine();
                while (intput != "1" && intput != "2" && intput != "3")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("請輸入1或2或3");
                    Console.ForegroundColor = ConsoleColor.White;
                    intput = Console.ReadLine();
                    if (intput == "1" || intput == "2" || intput == "3")
                    {
                        break;
                    }
                }
                //根據輸入的資料，獲得一個打折的對象
                Discount dis = GetDiscount(intput);
                double totalMoney = dis.GetTotalMoney(price);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"打折後，應付{totalMoney}");
                Console.ReadKey(true);
                Console.WriteLine();

                Dictionary<string, int> ds = ShowDetail(pros);
                foreach (string key in ds.Keys)
                {
                    if (ds[key] > 0)
                    {
                        Console.WriteLine($"商品名稱：{key}，數量：{ds[key]}");
                    }
                }
            }
            

            Console.WriteLine("謝謝光臨，歡迎下次再來唷!");
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

        public Dictionary<string, int> ShowDetail(Product[] pros)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"您好，購物明細請查收");
            Console.ForegroundColor = ConsoleColor.White;

            Dictionary<string, int> ds = new Dictionary<string, int>();
            ds.Add("Acer筆電", 0);
            ds.Add("Samsung手機", 0);
            ds.Add("鹽巴", 0);
            ds.Add("香蕉", 0);
            foreach (var item in pros)
            {
                switch (item.Name)
                {
                    case "Acer筆電":
                        ds["Acer筆電"] += 1;
                        break;
                    case "Samsung手機":
                        ds["Samsung手機"] += 1;
                        break;
                    case "鹽巴":
                        ds["鹽巴"] += 1;
                        break;
                    case "香蕉":
                        ds["香蕉"] += 1;
                        break;
                }
            }
            return ds;
        }
    }
}
