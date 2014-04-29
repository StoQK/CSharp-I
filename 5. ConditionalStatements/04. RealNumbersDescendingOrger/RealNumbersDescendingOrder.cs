//Sort 3 real values in descending order using nested if statements.

using System;

class RealNumbersDescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers: ");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", firstNumber, thirdNumber, secondNumber);
                }
            }
            else 
            {
                Console.WriteLine("{0}, {1}, {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
        else if (secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("{0}, {1}, {2}", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", secondNumber, thirdNumber, firstNumber);
            }
        }
        else
        {
            Console.WriteLine("{0}, {1}, {2}", thirdNumber, secondNumber, firstNumber);
        }
    }
}
