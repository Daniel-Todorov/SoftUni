//Define a method Fib(n) that calculates the nth Fibonacci number. 

using System;
using System.Collections.Generic;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please, type an integer number N and press Enter: ");
        int n = int.Parse(Console.ReadLine());


        Console.WriteLine(FibonacciNumbers.Fib(n));
    }

    private static int Fib(int n)
    {
        List<int> sequence = new List<int>();
        sequence.Add(0);
        sequence.Add(1);

        int counter = 0;
        for (counter = 0; counter < n; counter++)
        {
            sequence.Add(sequence[sequence.Count - 2] + sequence[sequence.Count - 1]);
        }

        return sequence[n + 1];
    }
}
