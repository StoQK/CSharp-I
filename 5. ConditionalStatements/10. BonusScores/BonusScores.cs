﻿/*
 * Write a program that applies bonus scores to given scores in the range [1..9].
 * The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; 
 * if it is between 4 and 6, multiplies it by 100; 
 * if it is between 7 and 9, multiplies it by 1000. 
 * If it is zero or if the value is not a digit, the program must report an error.
   Use a switch statement and at the end print the calculated new value in the console.
 */

using System;

class BonusScores
{
    static void Main()
    {
        int score;
        Console.Write("Enter a digit in the range of [1-9]:");
        bool isnInt = int.TryParse(Console.ReadLine(), out score);

        if (isnInt && score > 0 && score < 10)
        {
            switch (score)
            {
                case 1: score = score * 10; break;
                case 2: score = score * 10; break;
                case 3: score = score * 10; break;
                case 4: score = score * 100; break;
                case 5: score = score * 100; break;
                case 6: score = score * 100; break;
                case 7: score = score * 1000; break;
                case 8: score = score * 1000; break;
                case 9: score = score * 1000; break;
            }
            Console.WriteLine("Score: " + score);
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }
    }
}
