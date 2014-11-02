//Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
//If the variable is int or double, the program increases it by one. 
//If the variable is a string, the program appends "*" at the end. 
//Print the result at the console. Use switch statement. 

using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please, chose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: 
                Console.Write("Please enter an integer: ");
                int optionOne = int.Parse(Console.ReadLine());
                Console.WriteLine(optionOne + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double optionTwo = double.Parse(Console.ReadLine());
                Console.WriteLine(optionTwo + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string optionThree = Console.ReadLine();
                Console.WriteLine(optionThree+ "*");
                break;
            default:
                break;
        }
    }
}
