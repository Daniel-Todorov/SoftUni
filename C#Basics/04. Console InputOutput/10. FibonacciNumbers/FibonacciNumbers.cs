//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
//Note that you may need to learn how to use loops. 
//Examples:

//n	    comments
//1	    0
//3	    0 1 1
//10	0 1 1 2 3 5 8 13 21 34

using System;
using System.Collections.Generic;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please, type an integer number N and press Enter: ");
        int n = int.Parse(Console.ReadLine());

        List<int> sequence = new List<int>();
        sequence.Add(0);
        sequence.Add(1);

        int counter = 0;
        for (counter = 0; counter < n - 1; counter++)
        {
            Console.Write("{0} ", sequence[counter]);
            sequence.Add(sequence[sequence.Count - 2] + sequence[sequence.Count - 1]);
        }
        Console.WriteLine("{0}", sequence[counter]);
    }
}
