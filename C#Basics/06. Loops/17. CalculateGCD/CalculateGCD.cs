//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. 
//Use the Euclidean algorithm (find it in Internet). 
//Examples:

//a	    b	    GCD(a, b)
//3	    2	    1
//60	40	    20
//5	    -15	    5


using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Please, type the first integer A and press Enter: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, type the second integer B and press Enter: ");
        int b = int.Parse(Console.ReadLine());

        int transVariable = 0;
        bool loop = true;
        while (loop)
        {
            if (a < b)
            {
                transVariable = a;
                a = b;
                b = transVariable;
            }
            a = a % b;
            if (a == 0)
            {
                loop = false;
            }
        }

        Console.WriteLine("The greatest common divisor of the two numbers is {0}", b);
    }
}
