using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] firstArray = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine(string.Join(" ", SumOfPolynomialCoeff(firstArray,secondArray)));
        }
        static int[] SumOfPolynomialCoeff(int [] arrayOne,int[] arrayTwo )
        {
            int[] arrayResult = new int[arrayOne.Length];
            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayResult[i]= arrayOne[i] + arrayTwo[i];

            }
            return arrayResult;
        }
    }
}
