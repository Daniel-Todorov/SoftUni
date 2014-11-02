//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintSequence
{
    static void Main()
    {
        int initialMember = 2;
        int displayableMember = initialMember;
        int numberOfDisplayedMembers = 10;
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
