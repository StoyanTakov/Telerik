using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class DecimalToHex
    {
        const string HexDigits = "0123456789ABCDEF";

        static string DecToHex(long decValue)
        {
           
            string result = string.Empty;

            do
            {
                int value = (int)(decValue % 16);
                result = HexDigits[value] + result;
                decValue /= 16;

            } while (decValue != 0);

            return result;
        }
        static void Main()
        {
            long decValue = long.Parse(Console.ReadLine());
            Console.WriteLine(DecToHex(decValue));
        }
    }
}
