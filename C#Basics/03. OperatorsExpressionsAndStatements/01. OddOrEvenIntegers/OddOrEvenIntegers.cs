//Write an expression that checks if given integer is odd or even. 
//Examples:

//n 	Odd?
//3	    true
//2 	false
//-2	false
//-1	true
//0 	false


using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Please, type an integer number and press Enter: ");
        int numberToCheck = int.Parse(Console.ReadLine());

        Console.WriteLine(numberToCheck % 2 == 1 ? "The number is odd." : "The number is even.");
    }
}
