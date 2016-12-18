namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class GSMTest
    {
        

        public static void GSM_Test()
        {
            Console.WriteLine("*************GSM Test*************");

            //Creating an array of few instances of the GSM class.
            GSM[] phones = new GSM[]
            {
                new GSM("IPhone 6S", "Apple", 3000, "Gosho",
                    new Battery("G5", 444, 155, BatteryType.Toshiba), new Display(12, 51515561)),
                new GSM("S7", "Samsung", 3000, "Dobri",
                    new Battery("G5", 422, 134, BatteryType.NiMH), new Display(7, 323145151)),
                new GSM("S5", "Samsung", 1000, "Ivancho",
                    new Battery("G2", 50, 5, BatteryType.LiIon), new Display(5, 500000))
                
            };

            //Display the information about the GSMs in the array.
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i]);
            }

            //Display the information about the static property IPhone4S.
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
