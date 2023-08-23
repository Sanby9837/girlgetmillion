using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P147
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請問~你想要哪一個品牌的筆電呀");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            nb.SayHello();
            Console.ReadKey();
        }

        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Lenovo":
                    nb = new Lenovo();
                    break;
                case "Asus":
                    nb = new Asus();
                    break;
                case "Acer":
                    nb = new Acer();
                    break;
                case "Dell":
                    nb = new Dell();
                    break;
            }
            return nb;
        }
    }

    public abstract class NoteBook
    {
        public abstract void SayHello();
    }

    public class Asus : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("Asus筆電現身ㄌ");
        }
    }

    public class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("Acer筆電現身ㄌ");
        }
    }

    public class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("Lenovo筆電現身ㄌ");
        }
    }

    public class Dell : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("Dell筆電現身ㄌ");
        }
    }

}
