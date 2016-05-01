using System;

class OddOrEven
{

    static void Main()
    {
        int numberInput = int.Parse(Console.ReadLine());
        if (numberInput % 2 == 0)
        {
            Console.WriteLine("even {0}", numberInput);
        }
        else
        {
            Console.WriteLine("odd {0}", numberInput);
        }
    }
}

