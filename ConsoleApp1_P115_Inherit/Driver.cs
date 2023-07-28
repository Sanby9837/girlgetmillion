using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P115_Inherit
{
    internal class Driver
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
    }
}
