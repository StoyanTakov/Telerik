using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodingDecoding
{
    class EncodingDecoding
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();

            var toParse = Console.ReadLine();

            Console.WriteLine(Encode(toParse, key));
        }

        static string Encode(string toParse, string Key)
        {
            var encoding = new StringBuilder();

            for (int curIndex = 0;
                     curIndex < toParse.Length;
                     curIndex++)
            {
                var keyIndex = curIndex % Key.Length;

                encoding.Append(
                    (char)(toParse[curIndex] ^ Key[keyIndex])
                    );
            }

            return encoding.ToString();
        }
    }
}
