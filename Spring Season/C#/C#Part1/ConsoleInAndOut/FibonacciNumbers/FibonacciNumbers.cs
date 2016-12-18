using System;

class FibonacciNumbers
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        ulong a = 0;
        ulong b = 1;
        if (n == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.Write("0, 1");
            for (ulong i = 1; i < n - 1; i++)
            {
                ulong temp = a + b;
                a = b;
                b = temp;
                Console.Write(", {0}", temp);
            }
        }
    }
}