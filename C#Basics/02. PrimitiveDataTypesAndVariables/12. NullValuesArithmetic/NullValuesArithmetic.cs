//Create a program that assigns null values to an integer and to a double variable. 
//Try to print these variables at the console. 
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? integerVariable = null;
        double? doubleVariable = null;

        Console.WriteLine("Printed NULL integer: {0}", integerVariable);
        Console.WriteLine("Printed NULL double: {0}", doubleVariable);

        integerVariable += 5;
        doubleVariable += 5.0;

        Console.WriteLine("Integer after adding 5: {0}", integerVariable);
        Console.WriteLine("Double after adding 5.0: {0}", doubleVariable);
    }
}
