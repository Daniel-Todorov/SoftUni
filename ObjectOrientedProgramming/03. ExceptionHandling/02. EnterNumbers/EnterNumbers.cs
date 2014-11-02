//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. 
//If the user enters an invalid number, let the user to enter again.

namespace _02.EnterNumbers
{
    using System;

    public class EnterNumbers
    {
        private static int counter = 0;

        public static void Main()
        {
            EnterNumbers.ReadNumber(1, 100);
        }

        public static void ReadNumber(int start, int end)
        {
            Console.Write("Please, enter a number in range [{0}...{1}] and press Enter: ", start, end);
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);

                if (start >= number || number >= end)
                {
                    throw new ArgumentOutOfRangeException("number", string.Format("The number should be between {0} and {1}.", start, end));
                }

                counter++;

                if (counter >= 10)
                {
                    return;
                }
                else
                {
                    start = number;

                    EnterNumbers.ReadNumber(start, end);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);

                EnterNumbers.ReadNumber(start, end);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

                EnterNumbers.ReadNumber(start, end);
            }
        }
    }
}
