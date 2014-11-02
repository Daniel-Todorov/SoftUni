//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
//Use a sequence of if operators. 
//Examples:

//a	    b	    c	    result
//5	    2	    2	    +
//-2	-2	    1	    +
//-2	4	    3	    -
//0	    -2.5	4	    0
//-1	-0.5	-5.1	-

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please, type a real number A and press Enter: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, type a real number B and press Enter: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, type a real number C and press Enter: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
            return;
        }

        int negativeSigns = 0;
        if (a < 0)
        {
            negativeSigns++;
        }

        if (b < 0)
        {
            negativeSigns++;
        }

        if (c < 0)
        {
            negativeSigns++;
        }

        if (negativeSigns % 2 == 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}
