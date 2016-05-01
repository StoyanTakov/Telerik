using System;

class Program
{
    static void Main()
    {
        int birds = int.Parse(Console.ReadLine());
        double feathers = double.Parse(Console.ReadLine());
        double feathersPerBird =(double)(feathers / birds);
        double result;
        if (birds%2==0)
        {
            result = 123123123123 * feathersPerBird;
            Console.WriteLine("{0:F4}",result);
        }
        else
        {
            result = feathersPerBird / 317;
            Console.WriteLine("{0:F4}", result);
        }
    }
}

