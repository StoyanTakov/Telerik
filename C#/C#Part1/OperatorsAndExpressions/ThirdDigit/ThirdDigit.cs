using System;


namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberAfterMoving = number / 100;
            if (numberAfterMoving%10==7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}",numberAfterMoving);
            }
        }
    }
}
