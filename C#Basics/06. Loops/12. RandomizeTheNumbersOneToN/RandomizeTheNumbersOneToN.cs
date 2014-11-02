//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 
//Examples:

//n	    randomized numbers 1…n
//3	    2 1 3
//10	3 4 8 2 6 7 9 1 10 5 
//Note that the above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.

using System;
using System.Collections.Generic;

class RandomizeTheNumbersOneToN
{
    static void Main()
    {
        Console.Write("Please, type an integer number N and press Enter: ");
        int n = int.Parse(Console.ReadLine());

        List<int> numberContainer = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            numberContainer.Add(i);
        }

        Random randomGenerator = new Random();

        for (int i = 0; i < n; i++)
        {
            int randomPosition = randomGenerator.Next(0, numberContainer.Count);
            Console.Write("{0} ", numberContainer[randomPosition]);
            numberContainer.RemoveAt(randomPosition);
        }
    }
}
