using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        //Write a program that finds the maximal increasing sequence in an array. 
        // Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        //  Console.WriteLine("Enter {0} elements: ", length);
        for (int index = 0; index < length; index++)
        {
            array[index] = int.Parse(Console.ReadLine());
        }
        int maxSequence = 0;
        int sequence = 1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                sequence++;
            }

            else

            {
                if (maxSequence < sequence)
               {
                    maxSequence = sequence;
                }
                sequence = 1;
            }
        }
        Console.WriteLine(maxSequence);
    }
}
