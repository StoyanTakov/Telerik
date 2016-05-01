using System;

    class MMSAofNNumbers
    {
        static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n > 1)
        {
            double min = double.Parse(Console.ReadLine());
            double max = min;
            double sum = max;
            double avg = 0;
            for (int i = 1; i <= n - 1; i++)
            {
                double temp = double.Parse(Console.ReadLine());
                if (min > temp)
                {
                    min = temp;
                }
                if (max < temp)
                {
                    max = temp;
                }
                sum += temp;

            }
            avg = (Double)sum / n;
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avg);
        }
            if (n == 1)
            {
                 
                double min = double.Parse(Console.ReadLine());
                double max = min;
                double sum = min;
                double avg = min;
                Console.WriteLine("min={0:F2}", min);
                Console.WriteLine("max={0:F2}", max);
                Console.WriteLine("sum={0:F2}", sum);
                Console.WriteLine("avg={0:F2}", avg);
            }

        



    }
}

