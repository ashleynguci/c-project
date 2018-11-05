using System;
using Pointclass;
using triangle;
namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(4, 3);
            Point p3 = new Point(6, -2);
            Triangle abc = new Triangle(p1,p2,p3);
            double p = abc.Perimeter(p1, p2, p3);
            Console.WriteLine($"Point A: ({p1.X},{p1.Y})\nPoint B: ({ p2.X},{ p2.Y})\nPoint C: ({p3.X},{p3.Y})\nPerimeter:{p}");

            double area = abc.Area(p1, p2, p3);
            Console.WriteLine($"Area:{area}");
        }
    }
}
