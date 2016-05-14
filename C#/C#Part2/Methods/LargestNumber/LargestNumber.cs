using System;
using System.Linq;
    class LargestNumber
    {
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber>secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
        static void Main()
        {
        int[] inputNumbers = Console.ReadLine()           // Read the string
                                .Trim(' ')
                                .Split(' ')                  // split the string
                                .Select(x => int.Parse(x))   // convert to int and to array
                                .ToArray();
        int maxValue = int.MinValue;
        
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            maxValue = GetMax(maxValue, inputNumbers[i]);
        }
        Console.WriteLine(maxValue);
        }
    }

