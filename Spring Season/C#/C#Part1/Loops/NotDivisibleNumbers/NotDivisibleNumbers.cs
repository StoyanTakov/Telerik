using System;

    class NotDivisibleNumbers
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        while (i <= n)
        {
            if (!(i%3==0) && !(i%7==0))
            {
                Console.Write(i+" ");
            }
            i++;
        }
        }
    }

