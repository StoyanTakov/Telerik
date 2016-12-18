using System;
class MoonGravity
{
    static void Main(string[] args)
    {
        double weight = double.Parse(Console.ReadLine());
        double gravity = weight * 0.17;
        Console.WriteLine("{0:F3}", gravity);
    }
}
