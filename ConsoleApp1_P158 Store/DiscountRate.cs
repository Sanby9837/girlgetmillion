using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P158_Store
{
    internal class DiscountRate : Discount
    {
        public double Rate
        {
            get;
            set;
        }
        public DiscountRate(double rate)
        {
            this.Rate = rate;
        }
        public override double GetTotalMoney(double price)
        {
            return price * this.Rate;
        }
    }
}
