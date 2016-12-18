using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class TriangleSurface
    {
    static double area, sideLength, altitude;
    static double TriangleArea(double sideLength,double altitude)
    {
        area = (sideLength * altitude) / 2;
        return area;
    }
        static void Main()
        {
        sideLength = double.Parse(Console.ReadLine());
        altitude = double.Parse(Console.ReadLine());
        area = TriangleArea(sideLength, altitude);
        Console.WriteLine("{0:F2}",area);
    }
    }

