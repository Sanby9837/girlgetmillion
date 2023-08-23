using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P149
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("要去哪邊?");
            int go = Convert.ToInt32(Console.ReadLine());
            Person p = new Person();
            p.Name = "Sanby";
            p.Age = 28;
            switch (go)
            {
                case 1: Fun1(p); break;
                case 2: Fun2(); break;
            }
        }

        static void Fun1(Person p)
        {
            using (FileStream fsWrite = new FileStream(@"C:\Users\User\Desktop\149.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsWrite, p);
            }
            Console.WriteLine("序列化成功");
            Console.ReadKey();
        }
        static void Fun2()
        {
            using (FileStream frRead = new FileStream(@"C:\Users\User\Desktop\149.txt", FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Person pp = (Person)bf.Deserialize(frRead);
                Console.WriteLine(pp.Name);
                Console.WriteLine(pp.Age);
                Console.ReadKey();
            }
        }
    }

    [Serializable]
    internal class Person
    {
        private string _name;
        private int _age;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
