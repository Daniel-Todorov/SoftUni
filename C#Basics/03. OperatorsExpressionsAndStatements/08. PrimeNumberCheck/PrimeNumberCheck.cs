//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). 
//Examples:

//n	    Prime?
//1	    false
//2	    true
//3	    true
//4	    false
//9	    false
//97	true
//51	false
//-3	false
//0	    false

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Please, type a positive integer number N (N <= 100) and press Enter: ");
        int numberToCheck = int.Parse(Console.ReadLine());

        bool isPrime = true;
        if (numberToCheck == 0 || numberToCheck == 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= (int)Math.Sqrt(numberToCheck); i++)
            {
                if (numberToCheck % i == 0)
                {
                    isPrime = false;
                }
            }
        }

        Console.WriteLine(isPrime ? "The number IS prime." : "The number is NOT prime.");
    }
}
