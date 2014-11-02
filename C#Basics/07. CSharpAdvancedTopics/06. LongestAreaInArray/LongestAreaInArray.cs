//Write a program to find the longest area of equal elements in array of strings. 
//You first should read an integer n and n strings (each at a separate line), 
//then find and print the longest sequence of equal elements (first its length, then its elements). 
//If multiple sequences have the same maximal length, print the leftmost of them. 

using System;
using System.Collections.Generic;

class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("Please, type a number N and press Enter: ");
        int n = int.Parse(Console.ReadLine());

        List<string> input = new List<string>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter an integer number and press Enter: ");
            input.Add(Console.ReadLine());
        }

        int maxOccurence = 0;
        int occurence = 0;
        List<string> possibleOutput = new List<string>();
        List<string> output = new List<string>();
        for (int i = 0; i < input.Count; i++)
        {
            for (int j = 0; j < input.Count; j++)
            {
                if (input[i].Equals(input[j]))
                {
                    occurence++;
                    possibleOutput.Add(input[i]);
                }
            }

            if (occurence > maxOccurence)
            {
                maxOccurence = occurence;
                output = possibleOutput;
            }

            occurence = 0;
            possibleOutput = new List<string>();
        }

        Console.WriteLine(maxOccurence);
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
    }
}
