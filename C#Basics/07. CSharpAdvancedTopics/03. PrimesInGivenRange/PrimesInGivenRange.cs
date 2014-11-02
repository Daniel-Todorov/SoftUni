//Write a method that calculates all prime numbers in given range and returns them as list of integers.
//Write a method to print a list of integers. 
//Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.

using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        Console.Write("Please, enter an integer A (A<B) and press Enter and press Enter: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, enter another integer B (A<B) and press Enter and press Enter: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(PrintListOfIntegers(FindPrimesInRange(a,b)));
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

    private static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> result = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (PrimesInGivenRange.IsPrime(i))
            {
                result.Add(i);
            }
        }

        return result;
    }

    private static bool IsPrime(int n)
    {
        int divider = 1;
        int count = 0;

        while (divider < Math.Sqrt(n))
        {
            if (n % divider == 0)
            {
                count++;
            }
            divider++;
        }

        if (count < 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
