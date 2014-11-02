//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
//Note that you may need to use a for-loop. 

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Please, type an integer number N and press Enter: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0.0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please, type a number and press Enter: ");
            sum = sum + double.Parse(Console.ReadLine());
        }

        Console.WriteLine("The sum of the numbers is {0}.", sum);
    }
}