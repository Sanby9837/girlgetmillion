using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P143
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //設備
    public abstract class Storage
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class Sdd:Storage
    {
        public override void Read()
        {
            Console.WriteLine("Sdd讀取");
        }

        public override void Write()
        {
            Console.WriteLine("Sdd寫入");
        }
    }

    public class Hdd : Storage
    {
        public override void Read()
        {
            Console.WriteLine("Hdd讀取");
        }

        public override void Write()
        {
            Console.WriteLine("Hdd寫入");
        }

        public class Mp3:Storage
        {

        }
    }
}
