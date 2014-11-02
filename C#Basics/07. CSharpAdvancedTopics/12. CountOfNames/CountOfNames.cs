//Write a program that reads a list of names and prints for each name how many times it appears in the list. 
//The names should be listed in alphabetical order. 
//Use the input and output format from the examples below. 

using System;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputList = input.Split(' ');

        var counts = inputList
    .GroupBy(w => w)
    .Select(g => new { Name = g.Key, Count = g.Count() })
    .ToList();

        foreach (var p in counts)
        {
            Console.WriteLine("{0} -> {1}", p.Name, p.Count);
        }
    }
}
