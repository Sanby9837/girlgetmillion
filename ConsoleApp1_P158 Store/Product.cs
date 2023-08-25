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

        public string Name
        {
            get;
            set;
        }

        public string ID
        {
            get;
            set;
        }

        public Product(double price, string name, string id)
        {
            this.Price = price;
            this.Name = name;
            this.ID = id;
        }
    }
}
