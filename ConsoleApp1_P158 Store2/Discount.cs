﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P158_Store_2
{
    abstract class Discount
    {
        public abstract double GetTotalMoney(double price);
    }
}