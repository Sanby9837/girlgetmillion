using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P158_Store
{
    internal class StoreHouse
    {
        List<List<Product>> list = new List<List<Product>>();

        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item[0].Name}有 {item.Count} 個， {item[0].Price} 元/個");
            }
        }

        public StoreHouse()
        {
            //加入list四個集合 list[0]Acer筆電 list[1]三星手機 list[2]鹽巴 list[3]banana
            list.Add(new List<Product>());
            list.Add(new List<Product>());
            list.Add(new List<Product>());
            list.Add(new List<Product>());
        }

        public void Input(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(27000, "Acer筆電", Guid.NewGuid().ToString()));
                        break;
                    case "Samsung":
                        list[1].Add(new Samsung(37000, "Samsung手機", Guid.NewGuid().ToString()));
                        break;
                    case "Salt":
                        list[2].Add(new Salt(45, "鹽巴", Guid.NewGuid().ToString()));
                        break;
                    case "Banana":
                        list[3].Add(new Banana(99, "香蕉", Guid.NewGuid().ToString()));
                        break;
                }
            }
        }

        public Product[] Output(string strType, int count)
        {
            Product[] pros = new Product[count];
            for (int i = 0; i < pros.Length; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        if (list[0].Count == 0)
                        {
                            Console.WriteLine("商品缺貨");
                        }
                        else
                        {
                            pros[i] = list[0][0];
                            list[0].RemoveAt(0);
                        }
                        break;
                    case "Samsung":
                        if (list[1].Count == 0)
                        {
                            Console.WriteLine("商品缺貨");
                        }
                        else
                        {
                            pros[i] = list[1][0];
                            list[1].RemoveAt(0);
                        }
                        break;
                    case "Salt":
                        if (list[2].Count == 0)
                        {
                            Console.WriteLine("商品缺貨");
                        }
                        else
                        {
                            pros[i] = list[2][0];
                            list[2].RemoveAt(0);
                        }
                        break;
                    case "Banana":
                        if (list[3].Count == 0)
                        {
                            Console.WriteLine("商品缺貨");
                        }
                        else
                        {
                            pros[i] = list[3][0];
                            list[3].RemoveAt(0);
                        }
                        break;
                }
            }
            return pros;
        }
    }
}
