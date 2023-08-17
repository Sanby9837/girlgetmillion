using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.請輸入圓形的半徑");
            double sh_r = Convert.ToDouble(Console.ReadLine());
            Shape shape = new Circle(sh_r);
            Console.WriteLine($"這個形狀的面積是{shape.GetArea():0.00}，周長是{shape.GetPerimeter():0.00}");
            Console.ReadKey();

            Console.WriteLine("2.請輸入正方形的長");
            double sh_l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3.請輸入正方形的寬");
            double sh_w = Convert.ToDouble(Console.ReadLine());
            Shape shape1 = new Spuare(sh_l, sh_w) ;
            Console.WriteLine($"正方形的面積是{shape1.GetArea():0.00}，周長是{shape1.GetPerimeter():0.00}");
            Console.ReadKey();
        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Circle : Shape
    {
        //半徑
        private double _radius;
        public double R
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public Circle(double r)
        {
            this.R = r;
        }
        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.R;
        }
    }

    public class Spuare : Shape
    {
        private double _length;
        public double L
        {
            get { return _length; }
            set { _length = value; }
        }

        private double _width;
        public double W
        {
            get { return _width; }
            set { _width = value; }
        }

        public Spuare(double l, double w)
        {
            this.L = l;
            this.W = w;
        }


        public override double GetArea()
        {
            return this.L * this.W;
        }

        public override double GetPerimeter()
        {
            return (this.W + this.L) * 2;
        }
    }
}


