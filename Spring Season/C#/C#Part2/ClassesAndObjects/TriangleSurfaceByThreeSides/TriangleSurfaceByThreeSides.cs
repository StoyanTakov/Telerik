using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceByThreeSides
{
    class TriangleSurfaceByThreeSides
    {
        static double firstSideLength,secondSideLength,thirdSideLength, area, perimeter;
        static double TriangleSurface(double firstSide, double secondSide, double thirdSide)
        {
            perimeter = (firstSide + secondSide + thirdSide) / 2;
            area = Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));
            return area;
        }
        static void Main(string[] args)
        {
            firstSideLength = double.Parse(Console.ReadLine());
            secondSideLength = double.Parse(Console.ReadLine());
            thirdSideLength = double.Parse(Console.ReadLine());
            area = TriangleSurface(firstSideLength, secondSideLength, thirdSideLength);
            Console.WriteLine("{0:F2}",area);
        }
    }
}
