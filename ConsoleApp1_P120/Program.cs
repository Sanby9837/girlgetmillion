using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where u go?");
            int go = Convert.ToInt32(Console.ReadLine());

            switch (go)
            {
                case 120:
                    P120();
                    break;
                case 122:
                    P122();
                    break;
                case 123:
                    P123();
                    break;
                case 124:
                    P124();
                    break;
                default: break;
            }
        }
        /// <summary>
        /// P120 里式替代
        /// </summary>
        static void P120()
        {
            //里氏替代
            //1.子類可以賦值給父類
            Student s1 = new Student();
            Person p1 = s1;
            Person p2 = s1;

            //如果需要使用父類作為參數，可以給子類代替
            string str = string.Join("|", new string[] { "1", "2", "3", "4" });
            Console.WriteLine(str);

            //2.如果父類中是子類對象，可以將父類轉為子類物件
            //p1是父類強制轉換-->(Studnet)
            Student s2 = (Student)p1;
            s2.StudentSelf();
            Console.ReadKey();

            //is的使用情境
            if (p1 is Teacher)
            {
                Student s3 = (Student)p2;
                s3.StudentSelf();
            }
            else
            {
                Console.WriteLine("轉換失敗");
            }
            Console.ReadKey();

            //as用法
            Teacher t1 = p1 as Teacher;
            Student t2 = p1 as Student;
            t2.StudentSelf();
            Console.ReadKey();

            Console.WriteLine("------------------------------------------");


            //建立10個新物件
            Person[] pers = new Person[10];
            //宣告亂數
            Random r = new Random();
            //利用亂數將子類賦值給父類
            for (int i = 0; i < pers.Length; i++)
            {
                int rNum = r.Next(1, 5);
                switch (rNum)
                {
                    case 1:
                        pers[i] = new Student();
                        break;
                    case 2:
                        pers[i] = new Teacher();
                        break;
                    case 3:
                        pers[i] = new Beauty();
                        break;
                    case 4:
                        pers[i] = new Hansome();
                        break;

                    default: break;
                }
            }

            //基於可以把父類強制轉換子類物件，故透過迴圈把10個轉為子類，再呼叫各自的function
            for (int i = 0; i < pers.Length; i++)
            {
                if (pers[i] is Student)
                {
                    ((Student)pers[i]).StudentSelf();
                }
                else if (pers[i] is Teacher)
                {
                    ((Teacher)pers[i]).TeacherSelf();
                }
                else if (pers[i] is Beauty)
                {
                    ((Beauty)pers[i]).BeautySelf();
                }
                else if (pers[i] is Hansome)
                {
                    ((Hansome)pers[i]).HansomeSelf();
                }
                else
                {
                    pers[i].PersonSelf();
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// ArrayList 動態陣列
        /// </summary>
        static void P122()
        {
            //動態陣列，未指定特定長度，可一直加，且類型可不同
            ArrayList list = new ArrayList();
            //加入單個元素
            list.Add(98543);
            list.Add("小小");
            list.Add(3.14);
            list.Add('c');
            list.Add(true);
            list.Add(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Person p = new Person();
            list.Add(p);
            //增加一個陣列或集合，顯示的時候就不用使用第148的方式跑for迴圈再強制轉換陣列
            list.AddRange(list);

            //移出單個物件
            list.Remove(98543);
            list.RemoveAt(3);
            for (int i = 0; i < list.Count; i++)
            {
                //Console.Write($"{list[i]}--");
                if (list[i] is int[])
                {
                    //list[i]的物件，強制轉換成int陣列，才知道他的長度
                    for (int j = 0; j < ((int[])list[i]).Length; j++)
                    {
                        //list[i]的物件，強制轉換成int陣列，再將該陣列的值顯示出
                        Console.Write($"{((int[])list[i])[j]}--");
                    }
                    Console.WriteLine();
                }
                else if (list[i] is Person)
                {
                    ((Person)list[i]).PersonSelf();
                }
                else
                {
                    Console.WriteLine(list[i]);
                }
            }
            Console.ReadKey();

        }

        /// <summary>
        /// ArrayList長度
        /// </summary>
        static void P123()
        {
            ArrayList p1 = new ArrayList();
            p1.Add("1");
            p1.Add("1");
            p1.Add("1");
            p1.Add("1");
            p1.Add("1");
            p1.Add("1");
            p1.Add("1");
            p1.Add("1");
            p1.Add("1");
            Console.WriteLine(p1.Count);
            Console.WriteLine(p1.Capacity);
            Console.ReadKey();
        }

        /// <summary>
        /// ArrayList練習
        /// </summary>
        static void P124()
        {
            //建立一個array，加入一些數字，並計算平均值及總和
            ArrayList array_all = new ArrayList();
            Console.WriteLine("請輸入想計算的數字");
            string check = Console.ReadLine();
            while (check != "ok")
            {
                int nums = Convert.ToInt32(check);
                array_all.Add(nums);
                Console.WriteLine("請輸入想計算的數字，或ok進行結算");
                check = Console.ReadLine();
            }
            int sum = 0;
            for (int i = 0; i < array_all.Count; i++)
            {
                sum += (int)array_all[i];
            }
            Console.WriteLine($"總合為{sum}，平均為{sum / (array_all.Count)}");
            Console.ReadKey();

            //長度為10的array，隨機加數字0~9
            //但要求中間的數字不重複
            ArrayList array_10 = new ArrayList();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = r.Next(0, 10);
                while (array_10.Contains(num))
                {
                    num = r.Next(0, 10);
                }
                array_10.Add(num);
            }

            for (int i = 0; i < array_10.Count; i++)
            {
                Console.WriteLine($"{array_10[i]}--");
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        public void PersonSelf()
        {
            Console.WriteLine("我是人類");
        }
    }
    public class Student : Person
    {
        public void StudentSelf()
        {
            Console.WriteLine("我是學生");
        }
    }
    public class Teacher : Person
    {
        public void TeacherSelf()
        {
            Console.WriteLine("我是老師");
        }
    }
    public class Beauty : Person
    {
        public void BeautySelf()
        {
            Console.WriteLine("我是美女");
        }
    }
    public class Hansome : Person
    {
        public void HansomeSelf()
        {
            Console.WriteLine("我是帥哥");
        }
    }
}
