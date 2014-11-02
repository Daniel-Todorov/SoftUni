//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. 
//As a result print the values a and b, separated by a space. 
//Examples:

//a	    b	    result
//5	    2	    2   5
//3	    4	    3   4
//5.5	4.5	    4.5 5.5

// !!! NOTE !!!
//The problem says "integer variables" but the example has floating point numbers!
using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please, type an integer A and press Enter: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, type an integer B and press Enter: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            int c = a;
            a = b;
            b = c;
        }

        Console.WriteLine("{0} {1}", a, b);
    }
}