using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());
           
            int bitPosition = 3;
            int mask = 1;
            mask = mask << bitPosition;

            int addMask = number & mask;

            if (addMask != 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0"); 
            }


            

        }
    }
}
