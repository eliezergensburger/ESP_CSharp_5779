using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D(2, -2);
            Point2D p2 = new Point2D(3, 1);
            if (p1.CompareTo(p2) < 0)
            {
                Console.WriteLine(p1);
            }
            //usingList0();
            //usingList();
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }

        private static void usingList0()
        {
            ArrayList list = new ArrayList();
            list.Add(12);
            list.Add("cow");
            list.Add("chicken");
            list.Add(true);

            foreach (object item in list)
            {
                Console.WriteLine(item);
            }
            if (((string)list[1]).CompareTo(((string)list[2])) > 0)
            {
                Console.WriteLine("great");
            }
        }

        private static void usingList()
        {
            string bbaba = "jihuighuyg";
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(2);
            list.Add(22);
            if (list[0].CompareTo(list[2]) == 0)
            {
                list.RemoveAt(2);
            }
            list.Sort();

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
