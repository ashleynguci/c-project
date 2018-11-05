using System;
using Pointclass;

namespace triangle
{
    public class Triangle
    {
        /// <summary>
        ///  class knows 3 objects
        /// </summary>
        private Point p1;
        private Point p2;
        private Point p3;

        /// <summary>
        /// default constructor
        /// </summary>
        public Triangle()
        {

        }

        ///// <summary>
        ///// parameterised constructor
        ///// </summary>
        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        ///// <summary>
        ///// side length method
        ///// </summary>
        public double Length(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(p1.X - p2.X), 2) +
                Math.Pow(Math.Abs(p1.Y - p2.Y), 2));
        }


        ///// <summary>
        ///// perimeter method
        ///// </summary>
        public double Perimeter(Point p1, Point p2, Point p3)
        {
            double ab = Length(p1, p2);
            double bc = Length(p2, p3);
            double ac = Length(p3, p1);

            return ab + bc + ac;
        }

        public double Area(Point p1, Point p2, Point p3){
            double s = Perimeter(p1, p2, p3) / 2;
            double ab = Length(p1, p2);
            double bc = Length(p2, p3);
            double ac = Length(p3, p1);
            return Math.Sqrt(s * (s - ab) * (s - bc) * (s - ac));
        }

    }
}

