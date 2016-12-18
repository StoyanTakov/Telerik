using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWords
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words, separated by spaces: ");
            string[] input = Console.ReadLine().Trim().Split(' ');
            var orderList = new StringBuilder();
            Array.Sort(input);
            
            foreach (var word in input)
            {
                orderList.AppendLine(word);
            }
            Console.WriteLine(orderList);
            
        }
    }
}
