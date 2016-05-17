using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static string ReversedNumber(string number)
        {
            string reversedNumber = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNumber += number[i];
            }
            return reversedNumber;
        }
        static void Main()
        {
            string toReverse = Console.ReadLine();
            toReverse = ReversedNumber(toReverse);
            if (toReverse.Contains('-'))
            {
                toReverse = toReverse.Remove(toReverse.Length-1);
                Console.WriteLine("-" + toReverse);
            }
            else
            {
                Console.WriteLine(toReverse);
            }
        }

    }
}

