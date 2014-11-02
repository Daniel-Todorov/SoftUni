//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). 
//The card faces should start from 2 to A. 
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
//Use 2 nested for-loops and a switch-case statement.

using System;

class PrintDeckof52Cards
{
    static void Main()
    {
        string currentCard = null;
        for (int i = 0; i < 13; i++)
        {
            switch (i)
            {
                case 0: currentCard = "2"; break;
                case 1: currentCard = "3"; break;
                case 2: currentCard = "4"; break;
                case 3: currentCard = "5"; break;
                case 4: currentCard = "6"; break;
                case 5: currentCard = "7"; break;
                case 6: currentCard = "8"; break;
                case 7: currentCard = "9"; break;
                case 8: currentCard = "10"; break;
                case 9: currentCard = "J"; break;
                case 10: currentCard = "Q"; break;
                case 11: currentCard = "K"; break;
                case 12: currentCard = "A"; break;
                default:
                    break;
            }

            Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", currentCard);
        }
    }
}
