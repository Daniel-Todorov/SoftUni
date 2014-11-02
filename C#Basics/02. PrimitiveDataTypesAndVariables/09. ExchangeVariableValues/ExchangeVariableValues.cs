//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. 
//Print the variable values before and after the exchange.

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = b;

        Console.WriteLine("a = {0}, b = {1}", a, b);

        b = a;
        a = c;

        Console.WriteLine("a = {0}, b = {1}", a, b);
    }
}
