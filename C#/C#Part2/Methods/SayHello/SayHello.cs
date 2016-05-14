using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class SayHello
    {
        static void PrintHello(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
        static void Main()
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }
    }
}
