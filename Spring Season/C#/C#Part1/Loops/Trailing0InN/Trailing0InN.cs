using System;

using System.Numerics;

    class Trailing0InN
    {
        static void Main()
        {
            int N, temporary;
            int numberOfZeroes = 0;
            BigInteger factorial = 1;
            bool isnInt = int.TryParse(Console.ReadLine(), out N);
            if (isnInt)
            {
                for (int i = 1; i < N + 1; i++)
                {
                    factorial = factorial * i;
                }
                
                if (N >= 5)
                {
                    do
                    {
                        temporary = N / 5;
                        if (temporary != 0)
                        {
                            numberOfZeroes = numberOfZeroes + temporary;
                            N = temporary;
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (true);
                }
                Console.WriteLine("{0}", numberOfZeroes);
            }
            

            }
        }
    
