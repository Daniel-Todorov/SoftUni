using System;
using System.Text;

class BitKillers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] input = new int[n];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        StringBuilder totalstring = new StringBuilder(); 
        for (int i = 0; i < input.Length; i++)
        {
            totalstring.Append(GetIntBinaryString(input[i]));
        }

        StringBuilder newString = new StringBuilder();
        int maxCounter = totalstring.Length;
        for (int i = 0, j = 1; i < maxCounter; i++)
        {
            if (i != j)
            {
                newString.Append(totalstring[i]);
            }
            else
            {
                j += step;
            }
        }

        if (newString.Length % 8 > 0)
        {
            newString.Append('0', 8 - newString.Length % 8);
        }

        for (int i = 0; i < newString.Length; i+=8)
        {
            Console.WriteLine(Convert.ToInt32(newString.ToString().Substring(i, 8), 2));
        }
    }

    static string GetIntBinaryString(int n)
    {
        char[] b = new char[8];
        int pos = 7;
        int i = 0;

        while (i < 8)
        {
            if ((n & (1 << i)) != 0)
            {
                b[pos] = '1';
            }
            else
            {
                b[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(b);
    }
}
