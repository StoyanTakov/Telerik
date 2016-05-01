using System;

class SortThreeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a >= b)
        {
            if (a >= c)
            {
                if (c >= b)
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }

            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        else if (b >= a)
        {
            if (b >= c)
            {
                if (c >= a)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }

            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }

        }
        else if (c >= a)
        {
            if (c >= b)
            {
                if (b >= a)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            
        }
    }
}
