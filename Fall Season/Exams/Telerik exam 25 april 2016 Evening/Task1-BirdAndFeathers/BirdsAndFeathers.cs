using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_BirdAndFeathers
{
    class BirdsAndFeathers
    {
        static void Main(string[] args)
        {
            int birds = int.Parse(Console.ReadLine());
            int feathers = int.Parse(Console.ReadLine());
            double avgFeathers = (double)(feathers) / birds;
            double finalResult = 0;
            if (birds%2==0)
            {
                finalResult = avgFeathers * 123123123123;
            }
            else
            {
                finalResult = avgFeathers / 317;
            }
            Console.WriteLine("{0:F4}",finalResult);
        }
    }
}
