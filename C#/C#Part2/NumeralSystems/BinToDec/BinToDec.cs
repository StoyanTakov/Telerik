using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToDec
{
    class BinToDec
    {
        static long BinaryToDecimal (string binary)
        {
            long sum = 0;
            foreach (char bit in binary)
            {
                sum= (bit - '0') + sum * 2;
            }
            return sum;
        }
        static void Main()
        {
            string binaryNumber = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(binaryNumber));
        }
    }
}
