// Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).


using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficient a: ");
        string firstInput = Console.ReadLine();
        double a;
        if (double.TryParse(firstInput, out a))
        {
            
        }
        else
        {
            Console.WriteLine("Invalid input");
            return;
        }
        Console.Write("Enter coefficient b: ");
        string secondInput = Console.ReadLine();
        double b;
        if (double.TryParse(secondInput, out b))
        {
            
        }
        else
        {
            Console.WriteLine("Invalid input");
            return;
        }
        Console.Write("Enter coefficient c: ");
        string thirdInput = Console.ReadLine();
        double c;
        if (double.TryParse(thirdInput, out c))
        {
            
        }
        else
        {
            Console.WriteLine("Invalid input");
            return;
        }
        double discirminant = (b * b) - (4 * a * c);
        double firstRoot;
        double secondRoot;
        if (discirminant == 0)
        {
            firstRoot = -b / (2 * a);
            secondRoot = firstRoot;
        }
        if (discirminant < 0)
        {
            Console.WriteLine("There are no real roots for the given quadratic equation");
        }
        else
        {
            firstRoot = (-b - Math.Sqrt(discirminant)) / (2 * a);
            secondRoot = (-b + Math.Sqrt(discirminant)) / (2 * a);
            Console.WriteLine("The first real root of the equation is: {0}. \nThe second real root of the equation is: {1}", firstRoot, secondRoot);
        }
    }
}
