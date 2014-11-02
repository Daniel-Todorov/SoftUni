//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
//The first and the second sequence of bits may not overlap. 
//Examples:

//n	            p	    q	    k	    binary representation of n	            binary result	                        result
//1140867093	3	    24	    3	    01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	    1107312677
//4294901775	24	    3	    3	    11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	    4194238527
//2369124121	2	    22	    10	    10001101 00110101 11110111 00011001	    01110001 10110101 11111000 11010001	    1907751121
//987654321	    2	    8	    11	    -	                                    -	                                    overlapping
//123456789	    26	    0	    7	    -	                                    -	                                    out of range
//33333333333	-1	    0	    33	    -	                                    -	                                    out of range


using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Please, type a unsigned integer number and press Enter: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Please, type the starting position P {p, p+1, …, p+k-1} and press Enter: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please, type the starting position Q {q, q+1, …, q+k-1} and press Enter: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Please, type the length of the sequence K and press Enter: ");
        int k = int.Parse(Console.ReadLine());

        if (p == q || (p < q && p + k - 1 >= q) || (p > q && q + k - 1 >= p))
        {
            Console.WriteLine("The two sequences are OVERLAPPING.");
            return;
        }

        if (p < 0 || q < 0 || p + k > 32 || q + k > 32)
        {
            Console.WriteLine("Part of the sequences are OUT OF RANGE.");
            return;
        }

        for (int i = 0; i < k; i++)
        {
            n = ExchangeBits(n, p + i, q + i);
        }

        Console.WriteLine("The result after the exchanges is {0}.", n);
    }

    private static uint ExchangeBits(uint number, int firstPosition, int secondPosition)
    {
        int firstBit = ExtractBitAtPosition(number, firstPosition);
        int secondBit = ExtractBitAtPosition(number, secondPosition);

        number = ChangeBitAtPosition(number, firstPosition, secondBit);
        number = ChangeBitAtPosition(number, secondPosition, firstBit);

        return number;
    }

    private static uint ChangeBitAtPosition(uint number, int position, int value)
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

    private static int ExtractBitAtPosition(uint number, int position)
    {
        number = number >> position;

        return (int)number & 1;
    }
}
