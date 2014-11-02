//Write a program that calculates with how many zeroes the factorial of a given number n has at its end. 
//Your program should work well for very big numbers, e.g. n=100000. 
//Examples:

//n	        trailing zeroes of n!	explaination
//10	    2	                    3628800
//20	    4	                    2432902008176640000
//100000	24999	                think why

using System;

class TrailingZeroesinNFactoriel
{
    static void Main()
    {
        Console.Write("Please, type the number N and press Enter: ");
        int n = int.Parse(Console.ReadLine());

        //Well, after some research on the net it seems there is a nice formula that doesn't even require the calculation of N!
        //So I'll just implement it here and the program will work even for 1000000!.
        int trailingZero = 0;
        double mathPow = 1.0;
        while (Math.Pow(5.0, mathPow) <= n)
        {
            trailingZero = trailingZero + n / (int)Math.Pow(5.0, mathPow);
            mathPow++;
        }
        Console.WriteLine("The number of trailing zeroes in {0}! is {1}.", n, trailingZero);
    }
}
