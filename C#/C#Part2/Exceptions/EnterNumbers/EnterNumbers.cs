using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {        
       static string exceptionMessage = "Exception";

        static int[] Numbers;

        static void Main()
        {
            var start = 1;
            var end = 100;

            // size of input + start + end.
            var arrSize = 10 + 2;

            Numbers = new int[arrSize];
            Numbers[0] = start;
            Numbers[Numbers.Length - 1] = end;

            // Fill the array.
            try
            {
                for (int element = 1;
                     element < arrSize - 1;
                     element++)
                {
                    Numbers[element] = int.Parse(Console.ReadLine());
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine(exceptionMessage);
                return;
            }

            // Check the array.
            for (int element = 1;
                     element < arrSize - 1;
                     element++)
            {
                if (ReadNumber(element - 1, arrSize - 1))
                {
                    continue;
                }
                else
                {
                    return;
                }
            }

            // print
            Console.WriteLine(string.Join(" < ", Numbers));
        }

        static bool ReadNumber(int start, int end)
        {
            try
            {
                if (!(Numbers[start] < Numbers[start + 1] &&
                      Numbers[start + 1] < Numbers[end]))
                {
                    throw new Exception(exceptionMessage);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }


            return true;
        }
    }
}