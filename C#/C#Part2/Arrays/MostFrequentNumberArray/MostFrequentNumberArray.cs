using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MostFrequentNumberArray
    {
        static void Main(string[] args)
        {
        int length = int.Parse(Console.ReadLine());
        int counter = 0;
        int bigCounter = 0;
        int seqNumber = 0;
        int[] myArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myArray);
        for (int i = 0; i < length; i++)
        {
            
        }
        for (int i = 0; i < length-1; i++)
        {
            if (myArray[i]==myArray[i+1])
            {
                counter++;
                if (bigCounter<=counter)
                {
                    bigCounter = counter;
                    seqNumber = myArray[i];
                }
            }
            else
            {
                counter = 0;
            }
            
        }
        Console.WriteLine("{0} ({1} times)",seqNumber,bigCounter+1);
        }
    }

