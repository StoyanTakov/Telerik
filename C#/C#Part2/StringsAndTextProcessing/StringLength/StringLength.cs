using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringLength
{
    static void AddingSymbolsToString(string input)
    {
        int maxLength = 20;
        if (input.Length <= maxLength)
        {
            Console.WriteLine(input.Replace(@"\", string.Empty).PadRight(maxLength, '*'));
        }

        else
        {
            Console.WriteLine(input);
        }
    }
    static void Main(string[] args)
    {
       
        string str = Console.ReadLine();
        AddingSymbolsToString(str);
    }
}

