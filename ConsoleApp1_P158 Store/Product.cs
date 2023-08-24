using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P158_Store
{
    internal class Product
    {
        public double Price
        {
            get;
            set;
        }

        public double Count
        {
            get;
            set;
        }

        public string ID
        {
            get;
            set;
        }

        public Product(double price, double count, string id) 
        {
            this.Price = price;
            this.Count = count;
            this.ID = id;
        }
    }
}
