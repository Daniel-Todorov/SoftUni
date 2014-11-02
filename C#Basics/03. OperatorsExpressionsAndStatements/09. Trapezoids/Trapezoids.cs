//Write an expression that calculates trapezoid's area by given sides a and b and height h. 
//Examples:
//a	    b	    h	    area	 
//5	    7	    12	    72	
//2	    1	    33	    49.5	
//8.5	4.3	    2.7	    17.28	
//100	200	    300	    45000	
//0.222	0.333	0.555	0.1540125	

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Please, type the side A of the trapezoid and press Enter: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, type the side B of the trapezoid and press Enter: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, type the height H of the trapezoid and press Enter: ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of the trapezoid is {0}.", ((a + b) / 2) * h);
    }
}
