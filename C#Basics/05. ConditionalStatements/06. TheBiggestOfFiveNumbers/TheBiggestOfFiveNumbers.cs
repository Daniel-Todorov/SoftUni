//Write a program that finds the biggest of five numbers by using only five if statements. 
//Examples:

//a	    b	    c	    d	    e	    biggest
//5	    2	    2	    4	    1	    5
//-2	-22	    1	    0	    0	    1
//-2	4	    3	    2	    0	    4
//0	    -2.5	0	    5	    5	    5
//-3	-0.5	-1.1	-2	    -0.1	-0.1

//!!! NOTE !!!
//I did it with 4 IFs only.
using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please, type five numbers and press Enter after each of them: ");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double forthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());

        double biggestNumber = firstNumber;
        if (biggestNumber < secondNumber)
        {
            biggestNumber = secondNumber;
        }
        if (biggestNumber < thirdNumber)
        {
            biggestNumber = thirdNumber;
        }
        if (biggestNumber < forthNumber)
        {
            biggestNumber = forthNumber;
        }
        if (biggestNumber < fifthNumber)
        {
            biggestNumber = fifthNumber;
        }

        Console.WriteLine(biggestNumber);
    }
}
