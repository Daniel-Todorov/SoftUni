//Write a program that reads 3 real numbers from the console and prints their sum. 
//Examples:

//a	    b	    c	    sum
//3	    4	    11	    18
//-2	0	    3	    1
//5.5	4.5	    20.1	30.1

using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Please, type a number A and press Enter: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, type a number B and press Enter: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, type a number C and press Enter: ");
        double c = double.Parse(Console.ReadLine());

        double sum = a + b + c;

        Console.WriteLine("The sum of the three numbers is {0}.", sum);
    }
}
