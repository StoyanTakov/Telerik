using System;


static class ComparingFloats
{

    static void Main()
    {
        double numberOne = double.Parse(Console.ReadLine());
        double numberTwo = double.Parse(Console.ReadLine());


        double difference = Math.Abs(numberOne * .000001);


        if (Math.Abs(numberOne - numberTwo) <= difference)
            Console.WriteLine("double1 and double2 are equal.");
        else
            Console.WriteLine("double1 and double2 are unequal.");
    }
}

