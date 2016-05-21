using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubstringInText
{
    static int counter;
    static int CheckText (string text, string subText)
    {
        counter = 0;
        int nextIndexOfSubText = text.IndexOf(subText);
        while (text.IndexOf(subText)!=-1)
        {
            counter++;
            nextIndexOfSubText = text.IndexOf(subText, nextIndexOfSubText + 1);
        }
        return counter;
    }
    static void Main()
    {
        string subText = Console.ReadLine();
        string text = Console.ReadLine();
        counter = CheckText(text, subText);
        Console.WriteLine(counter);
    }
}

