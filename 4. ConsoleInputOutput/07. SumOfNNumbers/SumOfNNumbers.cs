// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string firstInput = Console.ReadLine();
        double n;
        if (double.TryParse(firstInput, out n))
        {
            Console.WriteLine("Please enter {0} more numbers: ", n);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum = sum + double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum of the {1} numbers is: {0}", sum, n);
    }
}
