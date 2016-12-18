using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            
            GetMax(array);
            GetMin(array);
            GetAvg(array);
            GetSum(array);
            GetProduct(array);
        }
        static void GetMin(int[] array)
        {
            int max = int.MinValue;
            int tempMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                tempMax = array[i];
                if (tempMax>max)
                {
                    max = tempMax;
                }
            }
            Console.WriteLine(max);
        }
        static void GetMax(int[] array)
        {
            int min = int.MaxValue;
            int tempMin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                tempMin = array[i];
                if (tempMin < min)
                {
                    min = tempMin;
                }
            }
            Console.WriteLine(min);
        }
        static void GetAvg(int[] array)
        {
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            avg = ((double)(sum))/((double)(array.Length));
            Console.WriteLine("{0:F2}",avg);
        }
        static void GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum+=array[i];
            }
            Console.WriteLine(sum);
        }
        static void GetProduct(int[] array)
        {
            BigInteger product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine(product);
        }
    }
}
