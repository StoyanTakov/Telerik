using System;


class BiggestOfFive
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double bigNum1;
        double bigNum2;
        bigNum1 = Math.Max(a, b);
        bigNum2 = Math.Max(bigNum1, c);
        bigNum1 = Math.Max(bigNum2, d);
        bigNum2 = Math.Max(bigNum1, e);
        Console.WriteLine(bigNum2);


    }
}

