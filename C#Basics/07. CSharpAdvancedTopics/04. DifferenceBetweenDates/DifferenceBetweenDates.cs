//Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 

using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("Please, type a date in format dd.MM.yyyy and press Enter: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Please, type another date in format dd.MM.yyyy and press Enter: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine((secondDate - firstDate).Days);
    }
}
