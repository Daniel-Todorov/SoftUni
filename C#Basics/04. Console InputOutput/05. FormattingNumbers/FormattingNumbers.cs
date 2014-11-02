//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), 
//a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. 
//Each column should have a width of 10 characters. 
//The number a should be printed in hexadecimal, left aligned; 
//then the number a should be printed in binary form, padded with zeroes, 
//then the number b should be printed with 2 digits after the decimal point, right aligned; 
//the number c should be printed with 3 digits after the decimal point, left aligned. 
//Examples:

//a	    b	        c	        result
//254	11.6	    0.5	        |FE        |0011111110|     11.60|0.500     |
//499	-0.5559	    10000	    |1F3       |0111110011|     -0.56|10000     |
//0	    3	        -0.1234	    |0         |0000000000|         3|-0.123    |


using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Please, type an integer A (0 ≤ A ≤ 500) and press Enter: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, type a floating point B and press Enter: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, type a floating point C and press Enter: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine(" |" + String.Format("{0:X}".PadRight(10), a) + "|" + Convert.ToString(a, 2).PadLeft(10, '0') + "|" +
            String.Format("{0:0.00}".PadLeft(13), b) + "|" + String.Format("{0:0.000}".PadRight(14), c) + "|");
    }
}
