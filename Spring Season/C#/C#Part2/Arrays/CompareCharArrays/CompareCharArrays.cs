using System;

class CompareTwoCharArrays
{
    static void Main()
    {

        string array1 = Console.ReadLine();
        string array2 = Console.ReadLine();
        int index = 0;
        char[] arrayChar1;
        char[] arrayChar2;
        arrayChar1 = array1.ToCharArray();
        arrayChar2 = array2.ToCharArray();

        
        for (int i = 0; i < Math.Min(arrayChar1.Length, arrayChar2.Length); i++)
        {
            index = i;
            if (arrayChar1[i] != arrayChar2[i])
            {
                break;
            }
        }
        if (arrayChar1[index] < arrayChar2[index])
        {
            Console.WriteLine("<");
        }
        else if (arrayChar1[index] > arrayChar2[index])
        {
            Console.WriteLine(">");
        }
        else if (arrayChar1.Length <arrayChar1.Length)
        {
            Console.WriteLine("<");
        }
        else if (arrayChar1.Length > arrayChar1.Length)
        {
            Console.WriteLine(">");
        }
        else
        {
            Console.WriteLine("=");
        }
    }
}