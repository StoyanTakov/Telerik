using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbour
{
    class LargerThanNeighbour
    {
        static void Main()
        {
            int arrRange = int.Parse(Console.ReadLine());
            int[] arrayNumbers = Console.ReadLine()
                .Trim(' ')
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();

            Console.WriteLine(LargerNumberCount(arrayNumbers));

        }
        static int LargerNumberCount(int[] array)
        {
            int appearanceCount = 0;
            for (int i = 1; i < array.Length-1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    appearanceCount++;
                }
            }
            return appearanceCount;
        }
    }
}

