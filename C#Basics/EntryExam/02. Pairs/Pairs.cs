using System;
using System.Collections.Generic;

class Pairs
{
    static void Main()
    {
        List<int> pairValues = new List<int>();
        List<int> sortedPairValues = new List<int>();
        string input = Console.ReadLine();
        string[] parsedInput = input.Split(' ');

        int currentDiff = 0;
        int maxDiff = 0;

        for (int i = 0; i < parsedInput.Length; i += 2)
        {
            pairValues.Add(int.Parse(parsedInput[i].ToString()) + int.Parse(parsedInput[i + 1].ToString()));
            sortedPairValues.Add(int.Parse(parsedInput[i].ToString()) + int.Parse(parsedInput[i + 1].ToString()));
        }

        sortedPairValues.Sort();

        if (sortedPairValues[0] == sortedPairValues[sortedPairValues.Count - 1])
        {
            Console.WriteLine("Yes, value={0}", pairValues[0]);
            return;
        }
        else
        {
            for (int i = 0; i < pairValues.Count - 1; i++)
            {
                currentDiff = pairValues[i] - pairValues[i + 1];

                if (currentDiff > 0 && currentDiff > maxDiff)
                {
                    maxDiff = currentDiff;
                }
                if (currentDiff < 0 && -1 * currentDiff > maxDiff)
                {
                    maxDiff = -1 * currentDiff;
                }
            }

            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}
