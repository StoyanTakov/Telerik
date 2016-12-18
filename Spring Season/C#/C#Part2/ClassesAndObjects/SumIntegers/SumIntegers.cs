using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumIntegers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(SumArray(input));
    }
    static int SumArray(string input)
    {
        int[] array = input.Split(' ').Select(x=>int.Parse(x)).ToArray();
        return array.Sum();
    }
}

