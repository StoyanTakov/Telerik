using System;

    class Program
    {
        static void Main()
        {
        int arrayLines = int.Parse(Console.ReadLine());
        int[] array1 = new int[arrayLines];
        bool isSymetric = true;
        for (int i = 0; i < arrayLines; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        int[] array2 = new int[arrayLines];
        for (int i = 0; i < arrayLines; i++)
        {
            array2[i]= int.Parse(Console.ReadLine());
            if (array1[i]!=array2[i])
            {
                isSymetric = false;
            }
        }
        if (isSymetric==true)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
        }
    }

