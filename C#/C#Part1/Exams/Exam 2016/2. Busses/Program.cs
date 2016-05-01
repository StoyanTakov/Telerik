using System;

    class Program
    {
        static void Main()
        {
        int numberBusses = int.Parse(Console.ReadLine());
        int bussesGroups = 0;
        int defaultSpeed = 0;
        int newSpeed=0;
        for (int i = 0; i < numberBusses; i++)
        {
            int speedOfBuss = int.Parse(Console.ReadLine());
            if (speedOfBuss>defaultSpeed)
            {
                if (speedOfBuss>newSpeed)
                {

                }
                                      
            }
            else if (speedOfBuss==defaultSpeed)
            {
                bussesGroups++;
                
            }
            else
            {
               
                bussesGroups++;
                
            }
            newSpeed = defaultSpeed;
            defaultSpeed = speedOfBuss;

            
        }
        Console.WriteLine(bussesGroups);

        }
    }

