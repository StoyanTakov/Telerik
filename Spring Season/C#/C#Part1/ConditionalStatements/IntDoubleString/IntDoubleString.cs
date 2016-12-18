using System;

    class IntDoubleString
    {
        static void Main()
        {
        string input = Console.ReadLine();
        
        switch (input)
        {
            case "integer":int numberInteger = int.Parse(Console.ReadLine());
                Console.WriteLine(numberInteger+1); 
                break;
            case "real":double numberDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", numberDouble+1);
                break;
            case "text":string text = Console.ReadLine();
                Console.WriteLine("{0}*",text);
                break;
         
        }
    }
    }

