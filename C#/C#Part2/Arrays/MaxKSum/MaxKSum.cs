using System;
using System.Linq;
class MaxKSum
{
    static void Main()
    {
        // Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        // Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int bestSum = 0;
        for (int i = 0; i < n; i++)
        {
            //Console.Write("Enter array element {0}: ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }
        //Sorting the Array
        Array.Sort(myArray); 
       
        for (int i = 0; i < n; i++)
        {
        }
        for (int i = n - 1; i > n - k - 1; i--)
        {
            bestSum += myArray[i];
        }
        Console.WriteLine(bestSum);
    }

}





