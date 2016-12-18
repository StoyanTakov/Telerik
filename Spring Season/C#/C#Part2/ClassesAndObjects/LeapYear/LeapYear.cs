using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LeapYear
{
    static void Main()
    {
        int leapYear = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(leapYear);
        Console.WriteLine("{0}", isLeap ? "Leap" : "Common");

    }
}

