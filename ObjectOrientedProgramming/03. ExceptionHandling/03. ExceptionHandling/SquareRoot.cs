//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". 
//Use try-catch-finally.

namespace _03.ExceptionHandling
{
    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            Console.Write("Please, type a positive integer number and press Enter: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double result = Math.Sqrt(number);

                Console.WriteLine("The square root of {0} is {1}", number, result);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException){
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
