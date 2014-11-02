//Write a program that gets two numbers from the console and prints the greater of them. 
//Try to implement this without if statements. 
//Examples:

//a	    b	    greater
//5	    6	    6
//10	5	    10
//0	    0	    0
//-5	-2	    -2
//1.5	1.6	    1.6

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Please, type the first number and press Enter: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please, type the second number and press Enter: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("The greater number is: ");
        Console.WriteLine(firstNumber > secondNumber ? firstNumber : secondNumber);
    }
}
