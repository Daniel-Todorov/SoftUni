//In combinatorics, the Catalan numbers are calculated by the following formula:
//Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
//Examples:

//n	    Catalan(n)
//0	    1
//5	    42
//10    16796
//15    9694845

using System;

class CatalanNumbers
{
    static void Main()
    {
        ulong N = 0;
        ulong factorialN = 1;
        ulong specialProduction = 1;
        ulong catalanNumber = 0;

        Console.Write("Please, type N (1 < N < 100) to calculate its coresponding Catalan number and press Enter: ");
        N = ulong.Parse(Console.ReadLine());

        //According to my personal calculation based on the formula, I found out a shorter version of it:
        //The production of the last N-1 in 2*N factorial divided by N! (if N = 5 -> C5 = (6*7*8*9*10) / (1*2*3*4*5)

        //Calculating N!
        for (ulong a = 1; a <= N; a++)
        {
            factorialN = factorialN * a;
        }

        //Calculate the special production
        for (ulong b = N + 2; b <= 2 * N; b++)
        {
            specialProduction = specialProduction * b;
        }

        //By definition Cn = 1 when N = 0 contrary to the conventional formula so we implement this case too
        if (N > 0)
        {
            catalanNumber = specialProduction / factorialN;
            Console.WriteLine(catalanNumber);
        }
    }
}
