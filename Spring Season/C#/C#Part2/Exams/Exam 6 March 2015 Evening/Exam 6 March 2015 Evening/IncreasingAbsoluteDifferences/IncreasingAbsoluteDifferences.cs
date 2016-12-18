using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAbsoluteDifferences
{
    class IncreasingAbsoluteDifferences
    {
        static void Main(string[] args)
        {
            int rowInputs = int.Parse(Console.ReadLine());
            for (int row = 0; row < rowInputs; row++)
            {
                var sequenceNumbers = Console.ReadLine()
                                                          .Split(' ')
                                                          .Select(long.Parse)
                                                          .ToArray();
                bool isIncreasingSequence = true;
                for (int i = 2; i < sequenceNumbers.Length; i++)
                {
                    var lastAbsDiff = Math.Abs(sequenceNumbers[i - 2] - sequenceNumbers[i - 1]);
                    var currentAbsDiff = Math.Abs(sequenceNumbers[i-1] - sequenceNumbers[i]);
                    if (lastAbsDiff>currentAbsDiff || currentAbsDiff-lastAbsDiff>1)
                    {
                        isIncreasingSequence = false;
                        break;
                    }
                }
                Console.WriteLine(isIncreasingSequence);
            }
            
        }
    }
}
