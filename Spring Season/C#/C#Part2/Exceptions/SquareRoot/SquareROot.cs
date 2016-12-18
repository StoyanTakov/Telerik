using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {


            try
            {
                double squareNumber = double.Parse(Console.ReadLine());
                var sqrt = Math.Sqrt(squareNumber).ToString("F3");
                if (sqrt=="NaN")
                {
                    throw new FormatException();
                }
                else
                {
                    Console.WriteLine(sqrt);
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid number");
            }
            finally
            {

                Console.WriteLine("Good bye");
            }
        }
    }
}
