//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime birthday = new DateTime();
        int afterTenYears = 0;
        string userInput = null;

        Console.WriteLine("Please, type your birthday in the following format (dd.mm.yyyy) and press Enter:");
        userInput = Console.ReadLine();

        while (!DateTime.TryParse(userInput, out birthday))
        {
            Console.WriteLine("Wrong date or format, please, try again:");
            userInput = Console.ReadLine();
        }

        afterTenYears = (DateTime.Today.Year - birthday.Year) + 10;

        Console.WriteLine("After 10 years you will be {0} years old.", afterTenYears);
    }
}
