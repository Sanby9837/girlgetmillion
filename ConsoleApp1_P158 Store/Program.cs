﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P158_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperMarket sm = new SuperMarket();
            sm.ShowPros();
            Console.ReadKey(true);
            sm.AskBuying();
            Console.ReadKey(true);
        }
    }
}