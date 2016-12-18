using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        if (A>B)
        {
            Console.WriteLine("{0} {1}",B,A);
        }
        else
        {
            Console.WriteLine("{0} {1}", A,B);
        }
    }
    }

