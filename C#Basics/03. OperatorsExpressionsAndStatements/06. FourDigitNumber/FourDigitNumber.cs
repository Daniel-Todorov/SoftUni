﻿//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. 
//Examples:

//n	        sum of digits	reversed	last digit in front	    second and third digits exchanged
//2011	    4	            1102	    1201	                2101
//3333	    12	            3333	    3333	                3333
//9876	    30	            6789	    6987	                9786


using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please, input a four-digit integer number and press Enter: ");
        int numberToCheck = int.Parse(Console.ReadLine());

        int firstDigit = numberToCheck / 1000;
        int secondDigit = (numberToCheck / 100) % 10;
        int thirdDigit = (numberToCheck / 10) % 10;
        int forthDigit = numberToCheck % 10;

        Console.WriteLine("The sum of the digits is {0}.", firstDigit + secondDigit + thirdDigit + forthDigit);
        Console.WriteLine("The reversed number is {0}.", GenerateFourDigitNumber(forthDigit, thirdDigit, secondDigit, firstDigit));
        Console.WriteLine("The number with last digit in front is {0}.", GenerateFourDigitNumber(forthDigit, firstDigit, secondDigit, thirdDigit));
        Console.WriteLine("The number with switched second and third digit is {0}.", GenerateFourDigitNumber(firstDigit, thirdDigit, secondDigit, forthDigit));
    }

    private static int GenerateFourDigitNumber(int po1000, int po100, int po10, int po1)
    {
        return po1000 * 1000 + po100 * 100 + po10 * 10 + po1;
    }
}
