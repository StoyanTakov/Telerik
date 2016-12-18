using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static int[,] digits;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            digits = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                string[] currentLine = Console.ReadLine().Split(' ');
                for (int col = 0; col < currentLine.Length; col++)
                {
                    digits[row, col] = int.Parse(currentLine[col]);
                }
            }
        }
    }
}
