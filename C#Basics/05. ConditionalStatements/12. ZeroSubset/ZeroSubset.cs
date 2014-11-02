//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. 
//Assume that repeating the same subset several times is not a problem.

//Hint: you may check for zero each of the 32 subsets with 32 if statements.

using System;

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Please enter five integer numbers (on separate lines:)");
        int[] varNum = new int[5];
        int i;
        int j;
        int k;
        int m;
        bool hasZeroSums = false;
        for (i = 0; i < 5; i++)
        {
            varNum[i] = int.Parse(Console.ReadLine());
        }

        for (i = 0; i < 5; i++)
        {
            if (varNum[i] == 0)
            {
                hasZeroSums = true;
                Console.WriteLine(varNum[i]);
            }
        }
        for (i = 0; i < 4; i++)
        {
            for (j = i + 1; j < 5; j++)
            {
                if ((varNum[i] + varNum[j]) == 0)
                {
                    hasZeroSums = true;
                    Console.WriteLine("{0} \t {1}", varNum[i], varNum[j]);
                }
            }
        }
        for (i = 0; i < 3; i++)
        {
            for (j = i + 1; j < 4; j++)
            {
                for (k = j + 1; k < 5; k++)
                {
                    if ((varNum[i] + varNum[j] + varNum[k]) == 0)
                    {
                        hasZeroSums = true;
                        Console.WriteLine("{0} \t {1} \t {2}", varNum[i], varNum[j], varNum[k]);
                    }
                }

            }
        }
        for (i = 0; i < 2; i++)
        {
            for (j = i + 1; j < 3; j++)
            {
                for (k = j + 1; k < 4; k++)
                {
                    for (m = k + 1; m < 5; m++)
                    {
                        if ((varNum[i] + varNum[j] + varNum[k] + varNum[m]) == 0)
                        {
                            hasZeroSums = true;
                            Console.WriteLine("{0} \t {1} \t {2} \t {3}", varNum[i], varNum[j], varNum[k], varNum[m]);
                        }
                    }
                }

            }
        }
        if ((varNum[0] + varNum[1] + varNum[2] + varNum[3] + varNum[4]) == 0)
        {
            hasZeroSums = true;
            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", varNum[0], varNum[1], varNum[2], varNum[3], varNum[4]);
        }
        if (hasZeroSums == false)
        {
            Console.WriteLine();
            Console.WriteLine("no zero subset");
        }
    }
}
