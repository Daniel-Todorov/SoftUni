//Write a program that reads a list of letters and prints for each letter how many times it appears in the list. 
//The letters should be listed in alphabetical order. Use the input and output format from the examples below.

using System;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();

        for (int i = 1; i < 27; i++)
        {
            var count = input.Count(x => x == GetChar(i));
            if (count > 0)
            {
                Console.WriteLine("{0} -> {1}", GetChar(i), count);
            }
        }
    }

    private static char GetChar(int number)
    {
        switch (number)
        {
            case 1: return 'a';
            case 2: return 'b';
            case 3: return 'c';
            case 4: return 'd';
            case 5: return 'e';
            case 6: return 'f';
            case 7: return 'g';
            case 8: return 'h';
            case 9: return 'i';
            case 10: return 'j';
            case 11: return 'k';
            case 12: return 'l';
            case 13: return 'm';
            case 14: return 'n';
            case 15: return 'o';
            case 16: return 'p';
            case 17: return 'q';
            case 18: return 'r';
            case 19: return 's';
            case 20: return 't';
            case 21: return 'u';
            case 22: return 'v';
            case 23: return 'w';
            case 24: return 'x';
            case 25: return 'y';
            case 26: return 'z';
            default:
                return ' ';
        }
    }
}
