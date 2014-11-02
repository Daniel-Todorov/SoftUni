//Using loops write a program that converts a hexadecimal integer number to its decimal form. 
//The input is entered as string. 
//The output should be a variable of type long. 
//Do not use the built-in .NET functionality. 
//Examples:

//hexadecimal	    decimal
//FE	            254
//1AE3	            6883
//4ED528CBB4	    338583669684


using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Please, write a hexadecimal integer as a string and press Enter: ");
        string input = Console.ReadLine().ToUpper();

        long decimalReprsentation = 0;
        int digit = 0;
        for (int i = 0; i < input.Length; i++)
        {
            switch (input[input.Length - i - 1])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': digit = int.Parse(input[input.Length - i - 1].ToString()); break;
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break; 
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;
                default:
                    break;
            }
            decimalReprsentation += digit * (long)Math.Pow(16.0, i);
        }

        Console.WriteLine(decimalReprsentation);
    }
}
