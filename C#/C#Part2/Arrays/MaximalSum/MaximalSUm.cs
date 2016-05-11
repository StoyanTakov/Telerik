using System;


namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];          
            for (int i = 0; i < n; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int currentSum = myArray[0];
            int maxSum = myArray[0];

            for (int i = 1; i < n; i++)
            {
                if (currentSum < 0)
                {
                    currentSum = myArray[i];
                    
                }
                else
                {
                    currentSum += myArray[i];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;                           
                }
            }

            Console.WriteLine("{0}", maxSum);               
        }
    }
    }
