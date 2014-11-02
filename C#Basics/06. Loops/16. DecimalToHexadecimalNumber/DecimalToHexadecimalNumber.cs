//Using loops write a program that converts an integer number to its hexadecimal representation. 
//The input is entered as long. 
//The output should be a variable of type string. 
//Do not use the built-in .NET functionality. 
//Examples:

//decimal	        hexadecimal
//254	            FE
//6883	            1AE3
//338583669684	    4ED528CBB4

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Please type a long integer and press Enter: ");
        long input = long.Parse(Console.ReadLine());

        string rawOutput = null;
        long leftover = 0;
        while (input / 16 > 0)
        {
            leftover = input % 16;
            input = input / 16;
            switch (leftover)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: rawOutput = rawOutput + leftover; break;
                case 10: rawOutput = rawOutput + "A"; break;
                case 11: rawOutput = rawOutput + "B"; break;
                case 12: rawOutput = rawOutput + "C"; break;
                case 13: rawOutput = rawOutput + "D"; break;
                case 14: rawOutput = rawOutput + "E"; break;
                case 15: rawOutput = rawOutput + "F"; break;
                default:
                    break;
            }
        }

        switch (input)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9: rawOutput = rawOutput + input; break;
            case 10: rawOutput = rawOutput + "A"; break;
            case 11: rawOutput = rawOutput + "B"; break;
            case 12: rawOutput = rawOutput + "C"; break;
            case 13: rawOutput = rawOutput + "D"; break;
            case 14: rawOutput = rawOutput + "E"; break;
            case 15: rawOutput = rawOutput + "F"; break;
            default:
                break;
        }

        string refinedOutput = null;
        for (int i = 1; i <= rawOutput.Length; i++)
        {
            refinedOutput = refinedOutput + rawOutput[rawOutput.Length - i];
        }

        Console.WriteLine(refinedOutput);
    }
}
