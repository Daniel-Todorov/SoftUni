//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 
//Examples:

//r	    perimeter	area
//2	    12.57	    12.57
//3.5	21.99	    38.48


using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please, type the radius R of a circle and press Enter: ");
        double r = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;

        Console.WriteLine("The perimeter of the circle is {0:0.00} and its area is {1:0.00}.", perimeter, area);
    }
}
