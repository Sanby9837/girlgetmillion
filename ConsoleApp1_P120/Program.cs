using System;
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
