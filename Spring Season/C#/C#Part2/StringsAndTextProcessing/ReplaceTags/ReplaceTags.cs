using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string html = Console.ReadLine();
            

            // output
            //Tags replaced
            Console.WriteLine(Regex.Replace(html, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]"));
            Console.WriteLine();
        }
    }
}
