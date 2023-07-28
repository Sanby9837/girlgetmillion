using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P115_Inherit
{
    internal class Teacher
    {
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; } 
        }

        public void Teach()
        {
            Console.WriteLine("老師需要會教課");
        }
    }
}
