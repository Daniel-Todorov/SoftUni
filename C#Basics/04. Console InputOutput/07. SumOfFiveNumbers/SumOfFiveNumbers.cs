//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 
//Examples:

//numbers	    sum		numbers	            sum		numbers	            sum
//1 2 3 4 5	    15		10 10 10 10 10	    50		1.5 3.14 8.2 -1 0	11.84


using System;
using System.Collections.Generic;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Please, type 5 numbers separated by a space and press Enter: ");
        string input = Console.ReadLine();
        string[] listOfNumbers = input.Split(' ');

        double sum = 0.0;
        for (int i = 0; i < listOfNumbers.Length; i++)
        {
            sum = sum + double.Parse(listOfNumbers[i]);
        }

        Console.WriteLine("The sum of the numbers is {0}.", sum);
    }
}
