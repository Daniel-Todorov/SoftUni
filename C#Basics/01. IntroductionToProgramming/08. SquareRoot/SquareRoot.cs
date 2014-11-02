//Create a console application that calculates and prints the square root of the number 12345. 
//Find in Internet “how to calculate square root in C#”.

using System;

class SquareRoot
{
    static void Main()
    {
        double givenNumber = 12345;
        double squareRoot = 0.0;

        squareRoot = Math.Sqrt(givenNumber);

        Console.WriteLine("The square root of {0} is {1}.", givenNumber, squareRoot);
    }
}