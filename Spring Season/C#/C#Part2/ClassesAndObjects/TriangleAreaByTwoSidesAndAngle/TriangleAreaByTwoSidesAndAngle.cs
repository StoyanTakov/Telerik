using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAreaByTwoSidesAndAngle
{
    class TriangleAreaByTwoSidesAndAngle
    {
       
        static double firstSideLength, secondSideLength, angle, area;
        static double TriangleSurface(double firstSide, double secondSide, double angle)
        {
            area = (firstSide * secondSide * Math.Sin(angle * Math.PI / 180)) / 2; 
            return area;
            
        }
        static void Main(string[] args)
        {
            firstSideLength = double.Parse(Console.ReadLine());
            secondSideLength = double.Parse(Console.ReadLine());
            angle = double.Parse(Console.ReadLine());
            area = TriangleSurface(firstSideLength, secondSideLength,angle);
            Console.WriteLine("{0:F2}", area);
        }
    }
}
