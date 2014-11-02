//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
//Use only one loop. 
//Print the result with 5 digits after the decimal point.

//n	    x	    S
//3	    2	    2.75000
//4	    3	    2.07407
//5	    -4	    0.75781


using System;

class CalculateFactorielSum
{
    static void Main()
    {
        Console.Write("Please, type an integer number N and press Enter: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, type an integer number X and press Enter: ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1.0;
        double factoriel = 1.0;
        for (double i = 1; i <= n; i++)
        {
            for (double j = 1; j <= i; j++)
            {
                factoriel = factoriel * j;
            }
            sum = sum + factoriel / Math.Pow(x, i);
            factoriel = 1.0;
        }

        Console.WriteLine("1 + 1!/X + 2!/X^2 + ... + N!/X^N = {0:0.00000}", sum);
    }
}
