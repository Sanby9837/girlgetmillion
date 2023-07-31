using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P115_Inherit
{
    internal class Driver : Person
    {
        private string _area;
        public string Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public void Drive()
        {
            Console.WriteLine("司機需要會開車");
        }

        public Driver(string Name,int Age,char Gender,string Area) : base(Name,Age,Gender)
        {
            this.Area = Area;
        }
    }
}
