using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckBrackets
{
    static int countLeftBrackets, countRightBrackets;
    
    static void ChecksBrackets (string input)
    {
        int indexOfNextLeftBracket = input.IndexOf('(');
        int indexOfNextRightBracket = input.IndexOf(')');
        while (indexOfNextLeftBracket != -1)
        {
            countLeftBrackets++;
            indexOfNextLeftBracket = input.IndexOf(('('), indexOfNextLeftBracket + 1);
        }
        while (indexOfNextRightBracket != -1)
        {
            countRightBrackets++;
            indexOfNextRightBracket = input.IndexOf((')'), indexOfNextRightBracket + 1);
        }
        if (countLeftBrackets==countRightBrackets)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
       
    }
    static void Main()
    {
        string input = Console.ReadLine();
        ChecksBrackets(input);
       
    }
}

