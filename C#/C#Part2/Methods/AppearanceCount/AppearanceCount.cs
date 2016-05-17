using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AppearanceCount
{
    static void Main()
    {
        int arrRange = int.Parse(Console.ReadLine());
        int[] arrayNumbers = Console.ReadLine()
            .Trim(' ')
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToArray();
        int findNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(AppearanceNumber(arrayNumbers,findNumber));
            
    }
    static int AppearanceNumber(int[] array, int findNumber)
    {
        int appearanceCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==findNumber)
            {
                appearanceCount++;
            }
        }
        return appearanceCount;
    }
}

