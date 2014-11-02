//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 
//Examples:

//n	    Divided by 7 and 5?
//3	    false
//0	    false
//5	    false
//7	    false
//35	true
//140	true


using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Please, type an integer number to be checked and press Enter: ");
        int numberToCheck = int.Parse(Console.ReadLine());

        Console.WriteLine((numberToCheck % 7 == 0) && (numberToCheck % 5 == 0) ? "The number CAN be divided by 7 and 5." : "The number CANNOT be divided by 7 and 5.");
    }
}
