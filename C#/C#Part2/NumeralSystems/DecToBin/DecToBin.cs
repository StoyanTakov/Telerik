using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBin
{
    class DecToBin
    {
        static string DecToBinary(long decValue)
        {
            string binary = string.Empty;
            do
            {
                long bit = decValue % 2;
                binary = bit + binary;
                decValue/=2;
            } while (decValue!=0);
            return binary;
        }
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(DecToBinary(n));
        }
    }
}
