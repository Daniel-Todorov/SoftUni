//Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
//The input and output lists are given as words, separated by a space, each list at a separate line. 

using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split(' ');
        string[] namesToRemove = Console.ReadLine().Split(' ');

        List<string> listedNames = new List<string>();
        for (int i = 0; i < names.Length; i++)
        {
            listedNames.Add(names[i]);
        }

        for (int i = 0; i < namesToRemove.Length; i++)
        {
            while (listedNames.Contains(namesToRemove[i]))
            {
                listedNames.Remove(namesToRemove[i]);
            }
        }

        foreach (var item in listedNames)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
    }
}
