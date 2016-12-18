using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeChars
{
    class UnicodeChars
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();

            var outputString = new StringBuilder();

            // In HEX 
            var UnicodeFormat = "\\u{0:X4}";

            foreach (var letter in inputString)
            {
                outputString.Append(
                    string.Format(
                        UnicodeFormat,
                        (int)letter));
            }

            Console.WriteLine(outputString);
        }
    }
}