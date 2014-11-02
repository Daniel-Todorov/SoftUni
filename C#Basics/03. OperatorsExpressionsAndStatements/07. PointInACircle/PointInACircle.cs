//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
//Examples:

//x	    y	    inside	 
//0	    1	    true	
//-2	0	    true	
//-1	2	    false	
//1.5	-1	    true	
//-1.5	-1.5	false	
//100	-30	    false	
//0	    0	    true	
//0.2	-0.8	true	
//0.9	-1.93	false	
//1	    1.655	true	

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Please, write the X coordinate of the point and press Enter: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please, write the Y coordinate of the point and press Enter: ");
        double y = double.Parse(Console.ReadLine());

        double distanceFromCenter = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        Console.WriteLine(distanceFromCenter <= 2 ? "The point IS in the circle." : "The point is NOT in the circle.");
    }
}
