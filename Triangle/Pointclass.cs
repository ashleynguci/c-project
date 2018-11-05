using System;

namespace Pointclass
{
    /// <summary>
    ///  class knows 2D point coordinates
    /// </summary>
    public class Point
    {
        private double x;
        private double y;
        /// <summary>
        /// default constructor
        /// </summary>
        public Point()
        {
        }
        ///// <summary>
        ///// parameterised constructor
        ///// </summary>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// calculates distance from origo
        /// </summary>
        public double Length()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        /// <summary>
        /// calculates distance from a given point
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public double Length(Point p)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(X - p.x), 2) + Math.Pow(Math.Abs(Y - p.y), 2));
        }






        /// <summary>
        /// properties
        /// </summary>
        public double X { get => x; }
        public double Y { get => y; }

        /// <summary>
        /// set value to both coordinates
        /// </summary>
        public void XY(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

    }
}


