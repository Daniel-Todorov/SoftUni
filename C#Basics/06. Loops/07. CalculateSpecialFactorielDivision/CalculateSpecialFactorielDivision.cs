//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) 
//is calculated by the following formula:
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops. 
//Examples:

//n	    k	    n! / (k! * (n-k)!)
//3	    2	    3
//4	    2	    6
//10 	6	    210
//52	5	    2598960

using System;

class CalculateSpecialFactorielDivision
{
    static void Main()
    {
        double N = 0.0;
        double K = 0.0;
        double upperValue = 1.0;
        double lowerValue = 1.0;

        Console.Write("Please, type N (1 < K < N < 100) and press Enter: ");
        N = ulong.Parse(Console.ReadLine());
        Console.Write("Please, type K (1 < K < N < 100) and press Enter: ");
        K = ulong.Parse(Console.ReadLine());

        for (double a = N, b = 0; b < N - K; a--, b++)
        {
                upperValue = upperValue * a;
        }

        for (double b = 1; b <= N -K; b++)
        {
            lowerValue = lowerValue * b;
        }

        Console.WriteLine("N!/(K!*(N-K)!) = {0}", upperValue/lowerValue);
    }
}
