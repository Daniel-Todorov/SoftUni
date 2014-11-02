//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 
//Examples:

//n	                binary representation of n	                binary result	                            result
//1140867093	    01000100 00000000 01000000 00010101	        01000010 00000000 01000000 00100101	        1107312677
//255406592 	    00001111 00111001 00110010 00000000	        00001000 00111001 00110010 00111000	        137966136
//4294901775	    11111111 11111111 00000000 00001111	        11111001 11111111 00000000 00111111	        4194238527
//5351      	    00000000 00000000 00010100 11100111	        00000100 00000000 00010100 11000111	        67114183
//2369124121	    10001101 00110101 11110111 00011001	        10001011 00110101 11110111 00101001	        2335569705


using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Please, type a unsigned integer and press Enter: ");
        uint n = uint.Parse(Console.ReadLine());

        int bit3 = ExtractBitAtPosition(n, 3);
        int bit4 = ExtractBitAtPosition(n, 4);
        int bit5 = ExtractBitAtPosition(n, 5);
        int bit24 = ExtractBitAtPosition(n, 24);
        int bit25 = ExtractBitAtPosition(n, 25);
        int bit26 = ExtractBitAtPosition(n, 26);

        n = ChangeBitAtPosition(n, 24, bit3);
        n = ChangeBitAtPosition(n, 25, bit4);
        n = ChangeBitAtPosition(n, 26, bit5);
        n = ChangeBitAtPosition(n, 3, bit24);
        n = ChangeBitAtPosition(n, 4, bit25);
        n = ChangeBitAtPosition(n, 5, bit26);

        Console.WriteLine("The number after the exchanging is {0}.", n);
    }

    public static uint ChangeBitAtPosition(uint number, int position, int value)
    {
        if (value == 0)
        {
            uint mask = (uint)~(1 << position);
            uint result = number & mask;

            return result;
        }
        else if (value == 1)
        {
            uint mask = (uint)1 << position;
            uint result = number | mask;

            return result;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public static int ExtractBitAtPosition(uint number, int position)
    {
        number = number >> position;

        return (int)number & 1;
    }
}
