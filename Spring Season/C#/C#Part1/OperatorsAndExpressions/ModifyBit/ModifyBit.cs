using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
             ulong number = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int bitValue = int.Parse(Console.ReadLine());

        if (bitValue == 1)
        {
            ulong mask = (ulong)1 << position;
            number = (ulong)(number | mask);
            Console.WriteLine(number);
        }
        else
        {
            ulong mask = (ulong)(~(1 << position));
            number = (ulong)(number & mask);
            Console.WriteLine(number);
        }
        }
    }
}
