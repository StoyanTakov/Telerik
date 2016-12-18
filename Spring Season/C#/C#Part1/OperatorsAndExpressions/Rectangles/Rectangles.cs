using System;

class Rectangles
{
    static void Main()
    {
        double widht = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = widht * height;
        double perimeter = 2 * widht + 2 * height;
        Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
    }
}

