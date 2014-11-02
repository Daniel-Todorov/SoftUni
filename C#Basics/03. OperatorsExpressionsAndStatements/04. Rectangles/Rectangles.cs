//Write an expression that calculates rectangle’s perimeter and area by given width and height. 
//Examples:

//width	height	perimeter	area
//3	    4	    14	        12
//2.5	3	    11	        7.5
//5 	5	    20	        25


using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please, type the width of the rectangle and press Enter: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please, type the height of the rectangle and press Enter: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("The perimeter of the recrangle is {0} and it's area is {1}.", perimeter, area);
    }
}
