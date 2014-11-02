//Write an expression that checks for given integer if its third digit from right-to-left is 7. 
//Examples:

//n	        Third digit 7?
//5 	    false
//701	    true
//9703	    true
//877	    false
//777877	false
//9999799	true


using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Please, type an integer number to be checked and press Enter: ");
        int numberToCheck = int.Parse(Console.ReadLine());

        Console.WriteLine((numberToCheck / 100) % 10 == 7 ? "The third digit of the number IS 7." : "The third digit of the number is NOT 7.");
    }
}
