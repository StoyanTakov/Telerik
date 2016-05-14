using System;
  class NumberComparer
    {
        static void Main()
        {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        if (A>B)
        {
            Console.WriteLine("{0}",A);
        }
        else
        {
            Console.WriteLine("{0}", B);
        }
    }
    }

