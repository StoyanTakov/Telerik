using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            
            uint number = uint.Parse(Console.ReadLine());
            uint mask = 1;
            uint bit1;
            uint bit2;
            uint number1;
            byte k = 3;
            byte p = 24;
            
            for (byte i = 1; i <= 3; i++, k++, p++)
            {
                mask = mask << k;
                bit1 = (mask & number) >> k;
                mask = mask >> k;
                mask = mask << p;
                bit2 = (mask & number) >> p;
                mask >>= p;
                if (bit1 != bit2)
                {
                    if (bit1 == 1)
                    {
                        number1 = number | (mask << p);
                        number = number1 ^ (mask << k);
                    }
                    else
                    {
                        number1 = number ^ (mask << p);
                        number = number1 | (mask << k);
                    }
                }
            }
            Console.WriteLine("{0}",number);
        }
    }

}

