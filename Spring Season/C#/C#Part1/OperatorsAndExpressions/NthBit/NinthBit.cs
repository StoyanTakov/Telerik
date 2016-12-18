using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthBit
{
    class NinthBit
    {
        static void Main(string[] args)
        {
            long P = long.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            long moveNumberN = P >> N;
            long bit = moveNumberN & 1;
            Console.WriteLine(Convert.ToString(bit, 2));
        }
    }
}
