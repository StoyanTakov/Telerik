using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static int BinSearch(int[] arr, int key)
        {
            Array.Sort(arr);
            int iMax = arr.Length - 1;
            int iMin = 0;
            while (iMax >= iMin)
            {
                int iMidpoint = (iMin + iMax) / 2;
                if (arr[iMidpoint] < key)
                {
                    iMin = iMidpoint + 1;
                }
                else if (arr[iMidpoint] > key)
                {
                    iMax = iMidpoint - 1;
                }
                else
                {
                    return iMidpoint;
                }
            }
            return -1;
        }
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine(BinSearch(myArray, key));
        }
    }
}
