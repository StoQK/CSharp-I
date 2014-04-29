//Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbers1ToN
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer n to output the numbers in the interval [1..N]");
        Console.Write("n=");
        string userInput = Console.ReadLine();
        int n;
        if (int.TryParse(userInput, out n))
        {
            if (n <= 0)
            {
                for (int i = 1; i >= n; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
