//Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.

using System;

class PrimeChecker
{
    static void Main()
    {
        Console.WriteLine("Please, type an integer number N and press Enter:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(PrimeChecker.IsPrime(n));
    }

    private static bool IsPrime(int n)
    {
        int divider = 1;
        int count = 0;

        while (divider < Math.Sqrt(n))
        {
            if (n % divider == 0)
            {
                count++;
            }
            divider++;
        }

        if (count < 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
