using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double coordinates = Math.Sqrt(x * x + y * y);
            if (coordinates <= 2)
            {
                Console.WriteLine("yes {0:F2}", coordinates);
            }
            else
            {
                Console.WriteLine("no {0:F2}", coordinates);
            }
        }
    }
}
