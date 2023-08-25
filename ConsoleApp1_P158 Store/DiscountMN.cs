using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P158_Store
{
    internal class DiscountMN : Discount
    {
        public double M
        {
            get;
            set;
        }

        public double N
        {
            get;
            set;
        }

        public DiscountMN(double m, double n)
        {
            this.M = m;
            this.N = n;
        }

        public override double GetTotalMoney(double price)
        {
            if (price >= this.M)
            {
                return price - (int)(price / this.M) * this.N;
            }
            else
            {
                return price;
            }
        }
    }
}
