using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumbers
{
    static Random rng = new Random();
    static void Main()
    {
        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rng.Next(100,200+1));
        }
    }
}

