using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P98
{
    public class Ticket
    {
        //變數
        private double _distance;
        private double _price;

        //屬性(只讀不寫)
        public double Distance
        {
            get { return _distance; }
        }

        //屬性(只讀不寫)
        //0~100km 不打折
        //101~200 9.5折
        //201~300 9折
        //300以上 8折
        public double Price
        {
            get
            {
                if (Distance >= 300)
                {
                    return Distance * 1 * 0.8;
                }
                else if (Distance >= 200)
                {
                    return Distance * 1 * 0.9;
                }
                else if (Distance >= 100)
                {
                    return Distance * 1 * 0.95;
                }
                else
                {
                    return Distance * 1;
                }
            }
        }


        //在構造函式中賦值，並判斷不能小於0
        public Ticket(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }
            this._distance = distance;
        }

        public void ShowTicket()
        {
            Console.WriteLine($"總票價是{Distance}折扣後金額{Price}");
        }
    }
}
