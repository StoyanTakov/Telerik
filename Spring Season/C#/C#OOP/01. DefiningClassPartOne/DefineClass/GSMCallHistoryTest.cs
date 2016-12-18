namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            Console.WriteLine("*************Call History Test*************");
            //Create an instance of the GSM class.
            GSM samsung = new GSM("S5", "Samsung", 1000, "Ivancho", new Battery("G2", 50, 5, BatteryType.LiIon), new Display(5, 500000));

            //Add few calls.
            samsung.AddCall(new Call("30/05/2016", "14:06", "0884089756", 104));
            samsung.AddCall(new Call("23/01/2015", "12:42", "0883208975", 311));
            samsung.AddCall(new Call("31/04/2016", "11:12", "0884589752", 151));

            //Display the information about the calls.
            for (int i = 0; i < samsung.CallHistory.Count; i++)
            {
                Console.WriteLine(samsung.CallHistory[i]);
            }

            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine("Calls Price: {0:f2}", samsung.GetTotalCallPrice(0.37m));

            //Remove the longest call from the history and calculate the total price again.
            Call longestCall = samsung.CallHistory[0];
            foreach (var call in samsung.CallHistory)
            {
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }
            samsung.DeleteCall(longestCall);
            Console.WriteLine("Calls Price without longest: {0:f2}", samsung.GetTotalCallPrice(0.37m));

            //Finally clear the call history and print it.
            samsung.ClearCallHistory();
            Console.WriteLine("Call history cleared!");
        }
    }
}
    

