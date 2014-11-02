//Write a program that reads a number n and a sequence of n integers, sorts them and prints them. 

using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Please, type a number N and press Enter: ");
        int n = int.Parse(Console.ReadLine());

        List<int> input = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter an integer number and press Enter: ");
            input.Add(int.Parse(Console.ReadLine()));
        }

        input.Sort();
        Console.WriteLine(PrintListOfIntegers(input));
    }

    private static string PrintListOfIntegers(List<int> input)
    {
        string result = null;
        for (int i = 0; i < input.Count - 1; i++)
        {
            result = result + input[i] + ", ";
        }

        return result + input[input.Count - 1];
    }
}
