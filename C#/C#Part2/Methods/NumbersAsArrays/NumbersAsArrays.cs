using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAsArrays
{
    class NumbersAsArrays
    {
        private static sbyte size1;

        
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sizeOne = input[0];
            int sizeTwo = input[1];
            int one = 0;
            int[] result = new int[Math.Max(sizeOne, sizeTwo) + 1];
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < Math.Min(sizeOne, sizeTwo); i++)
            {
                result[i] = (firstArray[i] + secondArray[i] + one) % 10;
                one = (firstArray[i] + secondArray[i] + one) / 10;
            }

            if (sizeOne > sizeTwo)
            {
                for (int i = sizeTwo; i < sizeOne; i++)
                {
                    result[i] = (firstArray[i] + one) % 10;
                    one = (firstArray[i] + one) / 10;
                }
            }
            else if (sizeOne < sizeTwo)
            {
                for (int i = sizeOne; i < sizeTwo; i++)
                {
                    result[i] = (secondArray[i] + one) % 10;
                    one = (secondArray[i] + one) / 10;
                }
            }

            result[Math.Max(sizeOne, sizeTwo)] = one;
            int length = result.Length;
            for (int i = 0; i < length; i++)
            {
                if (i + 1 == length)
                {
                    if (result[i] == 0)
                    {
                        continue;
                    }
                }

                Console.Write(result[i] + " ");
            }


        }
    }
}
