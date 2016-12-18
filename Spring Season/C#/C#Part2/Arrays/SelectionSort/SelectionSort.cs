using System;
class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int temp;
        int[] myArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i; j < n - 1; j++)
            {
                if (myArray[j + 1] < myArray[i])
                {
                    temp = myArray[i];
                    myArray[i] = myArray[j + 1];
                    myArray[j + 1] = temp;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}

