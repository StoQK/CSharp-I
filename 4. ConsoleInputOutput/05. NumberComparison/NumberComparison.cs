// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.


using System;

class NumberComparison
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        string firstInput = Console.ReadLine();
        double firstNumber;
        if (double.TryParse(firstInput, out firstNumber))
        {
            
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        Console.Write("Enter the second number: ");
        string secondInput = Console.ReadLine();
        double secondNumber;
        if (double.TryParse(secondInput, out secondNumber))
        {
            
        }
        else
        {
            Console.WriteLine("Invalid output");
        }
        double biggerNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The bigger of the two numbers is: {0}", biggerNumber);
    }
}
