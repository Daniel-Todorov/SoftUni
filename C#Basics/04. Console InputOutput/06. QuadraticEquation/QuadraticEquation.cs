//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 
//Examples:

//a	    b	c	roots
//2	    5	-3	x1=-3; x2=0.5
//-1	3	0	x1=3; x2=0
//-0.5	4	-8	x1=x2=4
//5	    2	8	no real roots


using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please, type the coefficient A and press Enter:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the coefficient B and press Enter:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the coefficient C and press Enter:");
        double c = double.Parse(Console.ReadLine());

        if ((b * b) - (4 * c * a) > 0)
        {
            double x1 = (-1 * b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-1 * b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("The quadratic equation has two real roots: {0} and {1}.", x1, x2);
        }
        else if ((b * b) - (4 * c * a) == 0)
        {
            double x = -1 * (b / (2 * a));
            Console.WriteLine("The only real root of the quedratic equation is {0}", x);
        }
        else
        {
            Console.WriteLine("The quadratic equation has no real roots");
        }
    }
}
