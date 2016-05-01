using System;

class OddOrEvenProducts
{
    static void Main()
    {
        {
            int n = int.Parse(Console.ReadLine());
            while (n < 4 || n > 50)
            {
                n = int.Parse(Console.ReadLine());
            }
            string[] arr = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(arr[i]);
            }
            long p1 = 1, p2 = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    p1 = p1 * a[i];
                }
                else
                {
                    p2 = p2 * a[i];
                }
            }
            if (p1 == p2)
                Console.WriteLine("yes {0}", p1);
            else
            {
                Console.WriteLine("no {0} {1}", p1, p2);
            }
        }
    }
}