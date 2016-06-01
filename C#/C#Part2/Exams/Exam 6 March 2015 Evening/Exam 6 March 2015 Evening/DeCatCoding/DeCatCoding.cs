using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCatCoding
{
    class DeCatCoding
    {
        static ulong CatToDec(string catLanguage)
        {
            ulong result = 0;
            foreach (char digit in catLanguage)
            {
                result = (ulong)(digit - 'a') + result * 21;
            }
            return result;
        }
        static string DecTo26(ulong decValue)
        {
            string result = string.Empty;
            do
            {
                char digitValue =(char)((decValue % 26) + 'a');
                result = digitValue + result;
                decValue /= 26;
            } while (decValue!=0);

            return result;
        }
        static void Main(string[] args)
        {
            var catLanguage = Console.ReadLine()
                                                .Split(' ')
                                                .Select(CatToDec)
                                                .Select(DecTo26)
                                                .ToArray();
            Console.WriteLine(string.Join(" ",catLanguage));
        }
    }
}
