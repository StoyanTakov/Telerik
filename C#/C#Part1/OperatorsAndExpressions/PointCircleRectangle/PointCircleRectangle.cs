using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {

            
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distanceCircle = Math.Sqrt(Math.Pow((x - 1), 2.0) + Math.Pow((y - 1), 2.0));
            bool isInCircle = (distanceCircle <= 1.5);
            bool isInRectangle = ((x >= -1) && (x <= 5) && (y <= 1) && (y >= -1));
            Console.WriteLine((isInCircle ? "inside circle" : "outside circle") + " " + (isInRectangle ? "inside rectangle" : "outside rectangle"));
        }
    }


}
    

