//Using loops write a program that converts a binary integer number to its decimal form. 
//The input is entered as string. 
//The output should be a variable of type long. 
//Do not use the built-in .NET functionality. 
//Examples:

//binary	                        decimal
//0	                                0
//11	                            3
//1010101010101011	                43691
//1110000110000101100101000000	    236476736

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Please, write a string of 1s and 0s and press Enter: ");
        string input = Console.ReadLine();

        long decimalReprsentation = 0;
        for (int i = 0; i < input.Length; i++)
        {
            decimalReprsentation += long.Parse(input[input.Length - i - 1].ToString()) * (long)Math.Pow(2.0, i);
        }

        Console.WriteLine(decimalReprsentation);
    }
}
