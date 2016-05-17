using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class FirstLargerThanNeighbours
    {
         static void Main()
    {
        int arrRange = int.Parse(Console.ReadLine());
        int[] arrayNumbers = Console.ReadLine()
            .Trim(' ')
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToArray();

        Console.WriteLine(FirstLargerNumber(arrayNumbers));

    }
    static int FirstLargerNumber(int[] array)
    {
        int firstLargerNumberCount = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                firstLargerNumberCount=i;
                break;
            }
            else
            {
                firstLargerNumberCount=-1;
            }
        }
        return firstLargerNumberCount;
    }
}
