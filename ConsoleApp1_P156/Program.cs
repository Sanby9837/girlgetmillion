using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();
            fly.Fly();
            Bird bird = new Bird();
            bird.Fly();
            Console.ReadKey();
        }
    }

    public class Bird:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鳥會飛飛飛飛");
        }
        /// <summary>
        /// 顯示實現介面
        /// </summary>
        void IFlyable.Fly()
        {
            Console.WriteLine("介面的飛飛");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }
}
