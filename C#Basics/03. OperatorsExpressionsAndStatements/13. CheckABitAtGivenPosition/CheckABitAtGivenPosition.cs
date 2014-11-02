﻿//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. 
//Examples:

//n	        binary representation of n	    p	    bit @ p == 1
//5	        00000000 00000101	            2	    true
//0	        00000000 00000000	            9	    false
//15	    00000000 00001111	            1	    true
//5343	    00010100 11011111	            7	    true
//62241	    11110011 00100001	            11	    false

using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please, type an integer N and press Enter: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, type the position P and press Enter: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine(ExtractBitAtPosition(n, p) == 1 ? String.Format("The bit #{0} IS 1.", p) : String.Format("The bit #{0} is NOT 1.", p));
    }

    public static int ExtractBitAtPosition(int number, int position)
    {
        number = number >> position;

        return number & 1;
    }
}
