using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShort
{
    class BinaryShort
    {
        static void Main()
        {

            short input = short.Parse(Console.ReadLine());

            string inputToBinary = ShortToBinary(input);

            //Print the result in the following manner: the first bit is the sign (0 for positive, 1 for negative)
            //the next 15 bits are for the number

            Console.WriteLine(inputToBinary);
        }
        static string ShortToBinary(short number)
        {
            byte[] bytesInput = BitConverter.GetBytes(number); //get the number as an array of 4 bytes
            string inputToBinary = "";
            for (int i = 0; i < bytesInput.Length; i++) //convert each byte to its binary representation and pad
            {                                           //with zeroes to get 8 bits for each byte
                inputToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + inputToBinary;
            }
            return inputToBinary;
        }
    }
}