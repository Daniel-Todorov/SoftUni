//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
//34.567839023, 12.345, 8923.1234857, 3456.091? 
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        double first = 34.567839023;
        float second = 12.345F;
        double third = 8923.1234857;
        float forth = 3456.091F;

        Console.WriteLine("First number: {0}; second number: {1}; third number: {2}; forth number: {3}.", first, second, third, forth);
    }
}
