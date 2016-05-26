using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace StrangeLandNumbers
{
    class StrangeLandNumbers
    {
        static BigInteger Power(int number,int power)
        {
            BigInteger result = 1;
            for (int i = 0; i <power ; i++)
            {
                result *= number;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine()
                                            .Replace("f", "0")
                                            .Replace("bIN", "1")
                                            .Replace("oBJEC", "2")
                                            .Replace("mNTRAVL", "3")
                                            .Replace("lPVKNQ", "4")
                                            .Replace("pNWE", "5")
                                            .Replace("hT", "6");
            int power = 0;
            BigInteger decimalNumber = 0;
            for (int i = inputNumber.Length-1; i >=0 ; i--)
            {
                int currentNumber = inputNumber[i] - '0';
                decimalNumber += currentNumber * Power(7, power);
                power++;

            }
            Console.WriteLine(decimalNumber);
        }
    }
}
