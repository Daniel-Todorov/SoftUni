﻿//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. 
//Note that you may need to use a for-loop. 

using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Please, type an integer number N and press Enter: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}