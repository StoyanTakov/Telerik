using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            var compressed = new StringBuilder();
            compressed.Append(input[0]);
            for (int i = 0; i < input.Length-1; i++)
            {
                
                if (input[i+1]!=input[i])
                {
                    compressed.Append(input[i+ 1]);
                }
                else
                {
                    continue;
                }
                
            }
            
            Console.WriteLine(compressed);
        }
    }
}
