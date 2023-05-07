using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //變量類型 變量名稱;
            //變量名稱 = 值;
            //100
            int roomnumber; //在內存中開了一個能夠儲存整數稱為roomnumber的空間(宣告int類型變量)
            roomnumber = 100; //把100號房儲存到roomnumber空間中(賦予變量一個值)

            //也可以寫成 int roomnumber = 100;

            string zsName = "張三";
            //字串 string ""
            //字串 char '' (只能存入一個字、不能為空)
            //數值 int 整數
            //數值 double 整數&小數
            //金錢 decimal 值後要加加m

            float ddd = 3.3f;
            double dd = 3.33;
            decimal d = 3.3333m;

            Console.WriteLine(d);
            Console.ReadKey();

            // P14 可以不斷重新賦值 i最後是20
            int i = 10;
            i = 20;
            Console.WriteLine(i);

            // P15  不同型態的+代表不同意思 int數學的相加、string文字的相加
            int j = 20;
            j = j + 20;
            Console.WriteLine(j);

            string jb = "20";
            jb = jb + "30";
            Console.WriteLine(jb);
            Console.ReadKey();

            // P16 WriteLine中如何利用加顯示不同變量的東西 方法1
            string name = "Sanby";
            int age = 18;
            string work = "pm";
            Console.WriteLine("我的名字是：" + name + "age:" + age);

            // P17 WriteLine中如何利用加顯示不同變量的東西 方法2
            Console.WriteLine("我的名字是：{0} age:{1}", name, age);

            // P17 -1 WriteLine中如何利用加顯示不同變量的東西 方法3
            Console.WriteLine($"我的名字是：{name} age:{age}");

            // P18 如何將o1、o2值互換
            int o1 = 10;
            int o2 = 20;
            int o3 = o1;
            o1 = o2;
            o2 = o3;

            // P18 如何將o1、o2數字值互換，不使用第三的變數的話怎麼辦
            int oo1 = 70;
            int oo2 = 20;
            oo1 = oo1 - oo2; // oo1 => -10
            oo2 = oo1 + oo2; // oo2 => 10
            oo1 = oo2 - oo1; // oo1 => 20
            Console.WriteLine(oo1);
            Console.WriteLine(oo2);
            Console.ReadKey();
        }
    }
}
