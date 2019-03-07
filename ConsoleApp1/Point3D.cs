using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Point3D : Point2D, IComparable<Point3D>
    {
        private int z;
        public Point3D() : base()
        {
            this.z = 0;
        }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public int CompareTo(Point3D other)
        {
            double val1 = Math.Sqrt(x * x + y * y + z * z);
            double val2 = Math.Sqrt(other.x * other.x + other.y * other.y + other.z * other.z);

            return val1.CompareTo(val2);
        }
    }
}
