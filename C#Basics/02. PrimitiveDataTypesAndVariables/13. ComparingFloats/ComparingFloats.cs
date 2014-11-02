//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
//Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class ComparingFloats
{
    static void Main()
    {
        double a = 0.0;
        double b = 0.0;
        double eps = 0.000001;
        bool isEqual = false;

        Console.WriteLine("Please, type a floating point number to compare and press Enter: ");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Please, type a floating point number to compare and press Enter: ");
        b = double.Parse(Console.ReadLine());

        if ((a >= b && (a - b) < eps) || (a < b && (b - a) < eps))
        {
            isEqual = true;
        }

        Console.WriteLine(isEqual);
    }
}
