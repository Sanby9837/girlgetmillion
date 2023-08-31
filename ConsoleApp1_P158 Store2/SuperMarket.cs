using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P158_Store_2
{
    internal class SuperMarket
    {
        StoreHouse ck = new StoreHouse();
        //購買物品及數量
        Dictionary<string, int> goods = new Dictionary<string, int>();

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
            goods.Add("Acer筆電", 0);
            goods.Add("Samsung手機", 0);
            goods.Add("鹽巴", 0);
            goods.Add("香蕉", 0);
            Console.Write("我們有");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Acer,Samsung,Salt,Banana");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            string strType = "";
            int count;
            int inv;
            double price = 0;
            string yn = "y";

            while (yn == "y")
            {
                count = BuySome(ref strType);
                inv = ck.GetInv(strType);


                if (inv > count)
                {
                    Product[] pros = ck.Output(strType, count);
                    price += GetMoney(pros);
                    AddCar(pros);
                    Console.WriteLine("請問還需要購買嗎?");
                    yn = Console.ReadLine();
                    while (true)
                    {
                        if (yn == "y" || yn == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("只能輸入y或n");
                            yn = Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("庫存不足，請問還有需要購買嗎?");
                    yn = Console.ReadLine();
                    while (true)
                    {
                        if (yn == "y" || yn == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("只能輸入y或n");
                            yn = Console.ReadLine();
                        }
                    }
                }

            }


            //算錢
            Console.WriteLine($"您需要支付{price}元");
            //Console.WriteLine($"請輸入打折方式 1.(Normal) 2.(8折) 3.(買千送百)");
            //string intput = Console.ReadLine();
            //while (intput != "1" && intput != "2" && intput != "3")
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("請輸入1或2或3");
            //    Console.ForegroundColor = ConsoleColor.White;
            //    intput = Console.ReadLine();
            //    if (intput == "1" || intput == "2" || intput == "3")
            //    {
            //        break;
            //    }
            //}
            ////根據輸入的資料，獲得一個打折的對象
            //Discount dis = GetDiscount(intput);
            //double totalMoney = dis.GetTotalMoney(price);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine($"打折後，應付{totalMoney}");
            //Console.ReadKey(true);
            Console.WriteLine();
            Console.ReadKey() ;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"您好，購物明細請查收");
            Console.ForegroundColor = ConsoleColor.White;
            ShowCar(goods);

            Console.WriteLine("謝謝光臨，歡迎下次再來唷!");
        }

        /// <summary>
        /// 加入已購買物品
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>
        public void AddCar(Product[] pros)
        {
            foreach (var item in pros)
            {
                switch (item.Name)
                {
                    case "Acer筆電":
                        goods["Acer筆電"] += 1;
                        break;
                    case "Samsung手機":
                        goods["Samsung手機"] += 1;
                        break;
                    case "鹽巴":
                        goods["鹽巴"] += 1;
                        break;
                    case "香蕉":
                        goods["香蕉"] += 1;
                        break;
                }
            }
        }

        /// <summary>
        /// 顯示購買資料
        /// </summary>
        /// <param name="ds"></param>
        public void ShowCar(Dictionary<string, int> ds)
        {
            foreach (string key in ds.Keys)
            {
                if (ds[key] > 0)
                {
                    Console.WriteLine($"商品名稱：{key}，數量：{ds[key]}");
                }
            }
        }

        /// <summary>
        /// 確認購買物品
        /// </summary>
        /// <param name="strType"></param>
        /// <returns></returns>
        public int BuySome(ref string strType)
        {

            Console.WriteLine("請問您需要什麼呢?");
            strType = Console.ReadLine().ToLower();
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
            return count;
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
