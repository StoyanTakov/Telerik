using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSort
    {
        static void QuickSortAlg(int[] arr, int left, int right)
        {
            int originalLeft = left;
            int originalRight = right;
            int pivot = arr[(left + right) / 2];

            while (left < right)
            {
                while (pivot > arr[left])
                {
                    left++;
                }
                while (pivot < arr[right])
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    left++;
                    right--;
                }
            }
            if (originalLeft < right)
            {
                QuickSortAlg(arr, originalLeft, right);
            }
            if (left < originalRight)
            {
                QuickSortAlg(arr, left, originalRight);
            }
        }
        static void Main()
        {

            //Write a program that sorts an array of strings using the quick sort algorithm
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            }
            QuickSortAlg(arr, 0, length-1);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
