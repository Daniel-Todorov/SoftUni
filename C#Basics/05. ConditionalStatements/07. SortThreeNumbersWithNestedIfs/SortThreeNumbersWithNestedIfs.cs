//Write a program that enters 3 real numbers and prints them sorted in descending order. 
//Use nested if statements. 
//Don’t use arrays and the built-in sorting functionality. 
//Examples:

//a	    b	    c	    result
//5	    1	    2	    5 2 1
//-2	-2	    1	    1 -2 -2
//-2	4	    3	    4 3 -2
//0	    -2.5	5	    5 0 -2.5
//-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
//10	20	    30	    30 20 10
//1	    1	    1	    1 1 1

using System;

class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Please, type three real numbers and press Enter after each of them: ");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        double number = thirdNumber;

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            if (secondNumber >= thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
            }
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
            }
        }
        else
        {
            if (secondNumber >= firstNumber)
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
    }
}
