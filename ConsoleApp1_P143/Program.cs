using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer cpu = new Computer();
            string whichone;
            do
            {
                Console.WriteLine("請輸入，你想讀取哪一種裝置(Sdd、Hdd、Mp3)");
                whichone = Console.ReadLine();
                if (whichone == "Sdd" || whichone == "Hdd" || whichone == "Mp3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("只能輸入Sdd、Hdd、或Mp3");
                    Console.ReadKey();
                }
            }
            while (true);
            Storage ms;
            if (whichone == "Mp3")
            {
                ms = new Mp3();
            }
            else if (whichone == "Hdd")
            {
                ms = new Hdd();
            }
            else
            {
                ms = new Sdd();
            }

            cpu.CpuRead(ms);
            cpu.CpuWrite(ms);
            Console.ReadKey();
        }

    }


    //設備
    public abstract class Storage
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class Sdd : Storage
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
    }

    public class Mp3 : Storage
    {
        public override void Read()
        {
            Console.WriteLine("Mp3讀取");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3寫入");
        }

        public void Play()
        {
            Console.WriteLine("Mp3 Play");
        }
    }

    public class Computer
    {
        public void CpuRead(Storage ms)
        {
            ms.Read();
        }

        public void CpuWrite(Storage ms)
        {
            ms.Write();
        }
    }
}
