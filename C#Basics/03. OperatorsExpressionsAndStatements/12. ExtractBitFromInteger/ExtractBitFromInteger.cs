//Write an expression that extracts from given integer n the value of given bit at index p. 
//Examples:

//n	        binary representation	p	    bit @ p
//5	        00000000 00000101	    2	    1
//0	        00000000 00000000	    9	    0
//15	    00000000 00001111	    1	    1
//5343	    00010100 11011111	    7	    1
//62241	    11110011 00100001	    11	    0


using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Please, type an integer N and press Enter: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, type the position P and press Enter: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("The bit #{0} is {1}.", p, ExtractBitAtPosition(n, p));
    }

    public static int ExtractBitAtPosition(int number, int position)
    {
        number = number >> position;

        return number & 1;
    }
}
