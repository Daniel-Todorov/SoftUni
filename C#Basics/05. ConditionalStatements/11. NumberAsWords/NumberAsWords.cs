//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 
//Examples:

//numbers	number as words
//0	        Zero
//9	        Nine
//10	    Ten
//12	    Twelve
//19	    Nineteen
//25	    Twenty five
//98	    Ninety eight
//273	    Two hundred and seventy three
//400	    Four hundred
//501	    Five hundred and one
//617	    Six hundred and seventeen
//711	    Seven hundred and eleven
//999	    Nine hundred and ninety nine

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Please, type an integer number in the range [0…999] and press Enter: ");
        int input = int.Parse(Console.ReadLine());

        string output = null;
        if (input <= 20)
        {
            Console.WriteLine(GetPrimalNumber(input));
        }
        else if (input < 100)
        {
            output = GetPrimalNumber((input / 10) * 10);
            if (input % 10 > 0)
            {
                output = output + " " + GetPrimalNumber(input % 10);
            }
        }
        else if (input < 1000)
        {
            output = GetPrimalNumber(input / 100) + " hundred";
            input = input % 100;
            if (input > 0 && input / 10 > 0)
            {
                output = output + " and " + GetPrimalNumber((input / 10) * 10);
                input = input % 10;
                if (input > 0)
                {
                    output = output + " " + GetPrimalNumber(input);
                }
            }
            else if (input > 0 && input / 10 == 0)
            {
                output = output + " and " + GetPrimalNumber(input);
            }
        }

        output = output.Substring(0, 1).ToUpper() + output.Substring(1);
        Console.WriteLine(output);
    }

    private static string GetPrimalNumber(int number)
    {
        string result = null;

        switch (number)
        {
            case 0: result = "zero"; break;
            case 1: result = "one"; break;
            case 2: result = "two"; break;
            case 3: result = "three"; break;
            case 4: result = "four"; break;
            case 5: result = "five"; break;
            case 6: result = "six"; break;
            case 7: result = "seven"; break;
            case 8: result = "eight"; break;
            case 9: result = "nine"; break;
            case 10: result = "ten"; break;
            case 11: result = "eleven"; break;
            case 12: result = "twelve"; break;
            case 13: result = "thirteen"; break;
            case 14: result = "forteen"; break;
            case 15: result = "fifteen"; break;
            case 16: result = "sixteen"; break;
            case 17: result = "seventeen"; break;
            case 18: result = "eighteen"; break;
            case 19: result = "nineteen"; break;
            case 20: result = "twenty"; break;
            case 30: result = "thirty"; break;
            case 40: result = "forty"; break;
            case 50: result = "fifty"; break;
            case 60: result = "sixty"; break;
            case 70: result = "seventy"; break;
            case 80: result = "eighty"; break;
            case 90: result = "ninety"; break;
            default:
                break;
        }

        return result;
    }
}
