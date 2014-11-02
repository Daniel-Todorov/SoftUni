//Write a program that reads from the console a sequence of n integer numbers and returns 
//the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = 0;
        int currentNumber = 0;
        int minNumber = 0;
        int maxNumber = 0;
        int sum = 0;
        double avarageSum = 0.0;

        Console.Write("Please, type a positive integer number N and press Enter: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber <= minNumber)
            {
                minNumber = currentNumber;
            }
            if (currentNumber >= maxNumber)
            {
                maxNumber = currentNumber;
            }
            sum += currentNumber;
        }
        avarageSum = (double)sum / n;

        Console.WriteLine("min = {0}", minNumber);
        Console.WriteLine("max = {0}", maxNumber);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", avarageSum);
    }
}
