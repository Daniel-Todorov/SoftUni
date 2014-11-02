//Write a program that finds the biggest of three numbers. 
//Examples:

//a	    b	    c	    biggest
//5	    2	    2	    5
//-2	-2	    1	    1
//-2	4	    3	    4
//0	    -2.5	5	    5
//-0.1	-0.5	-1.1	-0.1

using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please, type three numbers and press Enter after each of them: ");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        double biggestNumber = firstNumber;
        if (biggestNumber < secondNumber)
        {
            biggestNumber = secondNumber;
        }
        if (biggestNumber < thirdNumber)
        {
            biggestNumber = thirdNumber;
        }

        Console.WriteLine(biggestNumber);
    }
}
