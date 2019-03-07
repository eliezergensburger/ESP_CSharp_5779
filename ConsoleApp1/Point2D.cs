using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Point2D : IComparable
    {
        protected int x;
        protected int y;

        public Point2D()
        {
            x = 0;
            y = 0;
        }
        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            string result = string.Format("({0},{1})", x, y);
            return result;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Point2D))
            {
                throw new Exception("not a Point2D");
            }

            Point2D other = (Point2D)obj;

            double val1 = Math.Sqrt(x * x + y * y);
            double val2 = Math.Sqrt(other.x * other.x + other.y * other.y);
            return val1.CompareTo(val2);
        }
    }

}
