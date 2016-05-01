using System;

    class Printing
    {
        static void Main()
        {
        int numStudents = int.Parse(Console.ReadLine());
        int sheetsPerStudent = int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double realm = 500;
        double result = ((numStudents * sheetsPerStudent) / realm) * price;
        Console.WriteLine("{0:F2}",result);



    }
    }

