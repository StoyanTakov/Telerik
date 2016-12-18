using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class ParseTags
    {
        static void ToUpperSubtext(string[] input)
        {
            var output = new StringBuilder();
            var toUpper = false;
            var openTag = "upcase";
            var closeTag = "/upcase";
            foreach (var word in input)
            {
                if (word == openTag)
                {
                    toUpper = true;
                    continue;
                }

                if (word == closeTag)
                {
                    toUpper = false;
                    continue;
                }

                if (toUpper)
                {
                    output.Append(word.ToUpper());
                }
                else
                {
                    output.Append(word);
                }
            }
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            var toParse = Console
                .ReadLine()
                .Split(new char[] { '<', '>' })
                .ToArray();
            ToUpperSubtext(toParse);
        }
    }
}