//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. 
//Use two nested loops.

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Please, type an integer N (1 ≤ N ≤ 20) and press Enter: ");
        int N = int.Parse(Console.ReadLine());

        string result = null;
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1, k = i; j <= N; j++, k++)
            {
                result = result + k + " ";
            }
            Console.WriteLine(result);
            result = null;
        }
    }
}
