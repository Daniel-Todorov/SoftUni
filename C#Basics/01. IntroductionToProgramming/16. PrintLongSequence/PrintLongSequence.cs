//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
//You might need to learn how to use loops in C# (search in Internet).

using System;

class PrintLongSequence
{
    static void Main()
    {
        int initialMember = 2;
        int displayableMember = initialMember;
        int numberOfDisplayedMembers = 1000;
        string sequence = null;

        for (int i = 0; i < numberOfDisplayedMembers; i++)
        {
            if (displayableMember % 2 != 0)
            {
                sequence = sequence + string.Format("-{0}, ", displayableMember);
            }
            else
            {
                sequence = sequence + string.Format("{0}, ", displayableMember);
            }

            displayableMember++;
        }

        sequence = sequence.TrimEnd(' ', ',');

        Console.WriteLine(sequence);
    }
}
