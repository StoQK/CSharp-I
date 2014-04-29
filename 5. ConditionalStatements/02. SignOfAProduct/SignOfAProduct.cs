//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

class SignOfAProduct
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers each one on a separate line: ");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of their product is with a negative sign (-)");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of their product is with a positive sign (+)");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of their product is with a positive sign (+)");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of their product is with a negative sign (-)");
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of their product is with a positive sign (+)");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of their product is with a negative sign (-)");
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of their product is with a negative sign (-)");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of their product is with a positive sign (+)");
        }
        
        else
        {
            Console.WriteLine("0");
        }
    }
}
