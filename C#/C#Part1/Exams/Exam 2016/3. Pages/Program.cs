using System;

class Program
{
    static void Main()
    {

        int digits = int.Parse(Console.ReadLine());
        double result = 0;
        if (digits <10)
        {
            result = digits;
        }
        if (digits>=10 && digits<=189)
        {
            result = digits - 9;
            result =(Math.Ceiling(result/2)) + 9;
        }
        if (digits > 189 && digits <= 2889)
        {
            result = digits - 189;
            result =(Math.Ceiling(result/3))+99;
        }
        if (digits > 2889 && digits <= 38889)
        {
            result = digits - 2889;
            result = (Math.Ceiling(result / 4)) + 999;
        }
        if (digits >38889 && digits <= 488889)
        {
            result = digits - 38889;
            result = (Math.Ceiling(result / 5)) + 9999;
        }
        if (digits > 488889 && digits <=5888889)
        {
            result = digits - 488889;
            result = (Math.Ceiling(result / 6)) + 99999;
        }
        Console.WriteLine(result);
    }
}

