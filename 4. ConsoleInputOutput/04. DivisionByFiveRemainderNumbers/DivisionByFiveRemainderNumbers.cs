// Write a program that reads two positive integer numbers and 
// prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive).
// Example: p(17,25) = 2.


using System;

class DivisionByFiveRemainderNumbers
{
    static void Main()
    {
        Console.Write("Please enter the first integer of the interval: ");
        string firstInput = Console.ReadLine();
        int firstNumber;
        if (int.TryParse(firstInput, out firstNumber))
        {

        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        Console.Write("Please enter the second integer of the interval: ");
        string secondInput = Console.ReadLine();
        int secondNumber;
        if (int.TryParse(secondInput, out secondNumber))
        {

        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        int numberOne = Math.Max(firstNumber, secondNumber);
        int numberTwo = Math.Min(firstNumber, secondNumber);
        int p = 0;
        for (int i = numberTwo; i <= numberOne; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine(p);
    }
}
