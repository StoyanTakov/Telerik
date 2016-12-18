using System;

class Program
{
    static void Main()
    {
        int batmanPrint = int.Parse(Console.ReadLine());
        char batSignal = char.Parse(Console.ReadLine());
        char empty = ' ';
        int untillMidRow = (batmanPrint / 2);
        int width = 3 * batmanPrint;
        for (int row = 0; row <= untillMidRow; row++)
        {
            if (row == 0)
            {
                Console.Write("{0}{1}{0}", new string(batSignal, batmanPrint),
                    new string(empty, batmanPrint));
            }
            if (row > 0)
            {
                Console.Write("{0}{1}{2}{1}{0}", (empty++), new string(batSignal, (batmanPrint--)),
                    new string(empty, batmanPrint));
            }
            Console.WriteLine();

        }
       


    }


}


