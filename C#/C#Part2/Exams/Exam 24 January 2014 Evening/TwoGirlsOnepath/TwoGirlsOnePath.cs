using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TwoGirlsOnepath
{
    class TwoGirlsOnePath
    {
        static void Main(string[] args)
        {
            BigInteger[] flowerPath = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            int mollyIndex = 0;
            int dollyIndex = flowerPath.Length - 1;
            BigInteger totalMollyFlowers = 0;
            BigInteger totalDollyFlowers = 0;
            string winner = string.Empty;
            while (true)
            {
                if (flowerPath[mollyIndex] == 0 || flowerPath[dollyIndex]==0)
                {
                    if (flowerPath[mollyIndex] == 0)
                    {
                        winner = "Dolly";
                    }
                    else if (flowerPath[dollyIndex] == 0)
                    {
                        winner = "Molly";
                    }
                    else if (flowerPath[mollyIndex] == 0 && flowerPath[dollyIndex] == 0)
                    {                        
                            winner = "Draw";            
                    }
                    totalMollyFlowers += flowerPath[mollyIndex];
                    totalDollyFlowers += flowerPath[dollyIndex];

                    break;                                
                }
                BigInteger currentMollyFlowers = flowerPath[mollyIndex];
                BigInteger currentDollyFlowers = flowerPath[dollyIndex];
                if (mollyIndex==dollyIndex)
                {
                    flowerPath[mollyIndex] = currentMollyFlowers % 2;
                    totalMollyFlowers += currentMollyFlowers/2;
                    totalDollyFlowers += currentDollyFlowers/2;
                }
                else
                {
                    flowerPath[mollyIndex] = 0;
                    flowerPath[dollyIndex] = 0;
                    totalMollyFlowers += currentMollyFlowers;
                    totalDollyFlowers += currentDollyFlowers;
                }
                
                
                mollyIndex = (int)((mollyIndex + currentMollyFlowers) % flowerPath.Length);
                dollyIndex = (int)((dollyIndex - currentDollyFlowers) % flowerPath.Length);
                if (dollyIndex<0)
                {
                    dollyIndex += flowerPath.Length;
                }
            }
            Console.WriteLine(winner);
            Console.WriteLine("{0} {1}",totalMollyFlowers,totalDollyFlowers);
        }
    }
}
