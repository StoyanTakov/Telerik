using System;


class MaximalSequence
{
    static void Main()
    {
        //Write a program that finds the maximal sequence of equal elements in an array.


        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];


        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int counter = 0;
        int longestSequence = 0;

        for (int i = 0; i < length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                counter++;
                if (longestSequence < counter)
                {
                    longestSequence = counter;

                }
            }
            else
            {
                counter = 0;
            }
        }
        if (longestSequence == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("{0}", longestSequence + 1);
        }
    }
}