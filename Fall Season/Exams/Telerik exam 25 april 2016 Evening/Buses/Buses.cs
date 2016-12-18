using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    class Buses
    {
        static void Main(string[] args)
        {
            int numberBuses = int.Parse(Console.ReadLine());
           
            int count = 0;
            int groupSpeed = int.MaxValue;
            
            for (int i = 0; i < numberBuses; i++)
            {
                int speedBusses = int.Parse(Console.ReadLine());
                if ( groupSpeed>=speedBusses)
                {
                    groupSpeed = speedBusses;
                    count++;
                }
            }
            
            
            Console.WriteLine(count);
        }
    }
}
