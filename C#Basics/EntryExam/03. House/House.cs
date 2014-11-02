using System;
using System.Text;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder output = new StringBuilder();

        output.Append('.', n / 2);
        output.Append('*');
        output.Append('.', n / 2);
        Console.WriteLine(output);
        output = new StringBuilder();

        for (int i = 1; i < n / 2; i++)
        {
            output.Append('.', n / 2 - i);
            output.Append('*');
            output.Append('.', 2 * i - 1);
            output.Append('*');
            output.Append('.', n / 2 - i);

            Console.WriteLine(output);
            output = new StringBuilder();
        }

        output.Append('*', n);
        Console.WriteLine(output);
        output = new StringBuilder();

        for (int i = 0; i < n / 2 - 1; i++)
        {
            output.Append('.', n / 4);
            output.Append('*');
            output.Append('.', (n - 2) - (2 * (n / 4)));
            output.Append('*');
            output.Append('.', n / 4);

            Console.WriteLine(output);
            output = new StringBuilder();
        }

        output.Append('.', n / 4);
        output.Append('*', n - (2 * (n / 4)));
        output.Append('.', n / 4);

        Console.WriteLine(output);
        output = new StringBuilder();
    }
}
