using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int primeNumber = Int32.Parse(Console.ReadLine());
            if (primeNumber != 0 && primeNumber > 0 && primeNumber !=1)
            {
                if (primeNumber % primeNumber == 0 && primeNumber / 1 == primeNumber)
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
    }
        


