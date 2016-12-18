using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    class Pages
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            int pages = 0;
            int currentDigits = 0 ;
            for (int page = 1;currentDigits<digits; page++)
            {
                pages++;
                currentDigits += page.ToString().Length;
            }
            Console.WriteLine(pages);
        }
    }
}
