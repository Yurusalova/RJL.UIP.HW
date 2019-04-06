using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW9.EarthAreaCalculator.Shared.Models
{
    public class Point
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point))
            {
                return false;
            }
            var pointObj = (Point)obj;
            return pointObj.X == this.X && pointObj.Y == this.Y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.Y, p1.X - p2.Y);
        }

        public static bool operator <(Point p1, Point p2)
        {
            return p1.X < p2.X&&p1.Y<p2.Y;
        }

        public static bool operator >(Point p1, Point p2)
        {
            return p1.X > p2.X && p1.Y > p2.Y;
        }

    }
}
