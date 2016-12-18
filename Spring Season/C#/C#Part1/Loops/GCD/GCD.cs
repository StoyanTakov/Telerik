using System;

namespace GCD
{
    class GCD
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            int A = Math.Abs(int.Parse(input[0]));
            int B = Math.Abs(int.Parse(input[1]));
            int br = 1;

            while (!(br == 0))
            {

                br = A % B;
                A = B;
                B = br;
            }
            Console.WriteLine(A);
        }
    }
}


// 2nd way           String[] input = Console.ReadLine().Split(' ');
//                  int[] numbers = new int[input.Length];
//                  numbers = Array.ConvertAll(input, int.Parse);
//                      while (numbers[0] != 0 && numbers[1] != 0)
//                   {
//                        if (numbers[0] > numbers[1])
//                        numbers[0] %= numbers[1];
//                      else
//                       numbers[1] %= numbers[0];
//                   }

//                      if (numbers[0] == 0)
//                       Console.WriteLine(numbers[1]); 
//                       else
//                       Console.WriteLine(numbers[0]);          
//                   }