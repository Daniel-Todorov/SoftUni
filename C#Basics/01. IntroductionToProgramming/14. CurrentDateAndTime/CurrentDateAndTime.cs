//Create a console application that prints the current date and time. 
//Find in Internet how.

using System;
using System.Text;

class CurrentDateAndTime
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Now is {0} - {1}.", DateTime.Now.ToShortTimeString(), DateTime.Now.Date.ToShortDateString());
    }
}
