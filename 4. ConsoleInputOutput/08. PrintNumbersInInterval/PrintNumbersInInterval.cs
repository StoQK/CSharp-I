// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class PrintNumbersInInterval
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();
        int n;
        if (int.TryParse(input, out n))
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
