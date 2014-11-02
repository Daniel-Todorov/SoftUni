//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). 
//Use only one loop. 
//Examples:

//n	    k	n! / k!
//5	    2	60
//6	    5	6
//8	    3	6720

using System;

class CalculateFactorielProduction
{
    static void Main()
    {
        double N = 0.0;
        double K = 0.0;
        double division = 1.0;

        Console.Write("Please, type N (1 < K < N < 100) and press Enter: ");
        N = ulong.Parse(Console.ReadLine());
        Console.Write("Please, type K (1 < K < N < 100) and press Enter: ");
        K = ulong.Parse(Console.ReadLine());

        for (ulong a = 1; a <= N; a++)
        {
            if (a > K)
            {
                division = division * a;
            }
        }

        Console.WriteLine("N!/K! = {0}", division);
    }
}
