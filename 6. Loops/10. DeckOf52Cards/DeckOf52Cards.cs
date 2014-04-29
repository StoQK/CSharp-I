// Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
// The cards should be printed with their English names. 
// Use nested for loops and switch-case.

using System;

class DeckOf52Cards
{
    static void Main()
    {
        string suit = "";
        for (int i = 0; i < 4; i++)
        {
            switch (i)
            {
                case 0: suit = "Spades"; break;
                case 1: suit = "Diamonds"; break;
                case 2: suit = "Hearts"; break;
                case 3: suit = "Clubs"; break;
                default:
                    break;
            }

            for (int card = 2; card <= 14; card++)
            {
                switch (card)
                {
                    case 2: Console.WriteLine("Deuce {0}", suit); break;
                    case 3: Console.WriteLine("Three {0}", suit); break;
                    case 4: Console.WriteLine("Four {0}", suit); break;
                    case 5: Console.WriteLine("Five {0}", suit); break;
                    case 6: Console.WriteLine("Six {0}", suit); break;
                    case 7: Console.WriteLine("Seven {0}", suit); break;
                    case 8: Console.WriteLine("Eight {0}", suit); break;
                    case 9: Console.WriteLine("Nine {0}", suit); break;
                    case 10: Console.WriteLine("Ten {0}", suit); break;
                    case 11: Console.WriteLine("Ace {0}", suit); break;
                    case 12: Console.WriteLine("Jack {0}", suit); break;
                    case 13: Console.WriteLine("Queen {0}", suit); break;
                    case 14: Console.WriteLine("King {0}", suit); break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        } 
    }
}
