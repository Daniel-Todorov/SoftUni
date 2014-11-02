//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 
//Examples:

//x	    y	    inside K & outside of R	 
//1	    2	    yes	
//2.5	2	    no	
//0	    1	    no	
//2.5	1	    no	
//2	    0	    no	
//4	    0	    no	
//2.5	1.5	    no	
//2	    1.5	    yes	
//1	    2.5	    yes	
//-100	-100	no	

using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.Write("Please, write the X coordinate of the point and press Enter: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please, write the Y coordinate of the point and press Enter: ");
        double y = double.Parse(Console.ReadLine());

        double distanceFromCenter = Math.Sqrt(Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2));

        Console.WriteLine(((x < -1 || x > 5) || (y < -1 || y > 1)) && distanceFromCenter <= 1.5 ? "The point IS in the circle and outside the rectangle." : "The point is NOT in the circle and outside the rectangle.");
    }
}
