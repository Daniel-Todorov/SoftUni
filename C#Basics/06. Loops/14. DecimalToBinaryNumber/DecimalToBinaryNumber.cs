//Using loops write a program that converts an integer number to its binary representation. 
//The input is entered as long. 
//The output should be a variable of type string. 
//Do not use the built-in .NET functionality. 
//Examples:

//decimal	    binary
//0	            0
//3	            11
//43691	        1010101010101011
//236476736	    1110000110000101100101000000

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Please type a long integer and press Enter: ");
        long input = long.Parse(Console.ReadLine());

        string rawOutput = null;
        long leftover = 0;
        while (input / 2 > 0)
        {
            leftover = input % 2;
            input = input / 2;
            rawOutput = rawOutput + leftover;
        }
        rawOutput += input;

        string refinedOutput = null;
        for (int i = 1; i <= rawOutput.Length; i++)
        {
            refinedOutput = refinedOutput + rawOutput[rawOutput.Length - i];
        }

        Console.WriteLine(refinedOutput);
    }
}
