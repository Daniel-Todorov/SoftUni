//Write a program that takes as input two lists of integers and joins them. 
//The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. 
//The input and output lists are given as integers, separated by a space, each list at a separate line. 
//Examples:

//Input	                    Output
//20 40 10 10 30 80
//25 20 40 30 10	        10 20 25 30 40 80
//5 4 3 2 1
//6 3 2	1                   2 3 4 5 6
//1
//1	                        1

using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        string[] firstInput = Console.ReadLine().Split(' ');
        string[] secondInput = Console.ReadLine().Split(' ');

        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();

        for (int i = 0; i < firstInput.Length; i++)
        {
            firstList.Add(int.Parse(firstInput[i]));
        }

        for (int i = 0; i < secondInput.Length; i++)
        {
            secondList.Add(int.Parse(secondInput[i]));
        }

        List<int> result = new List<int>();
        for (int i = 0; i < secondList.Count; i++)
        {
            if (!firstList.Contains(secondList[i]))
            {
                firstList.Add(secondList[i]);
            }
        }

        firstList.Sort();
        foreach (var item in firstList)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
    }
}
