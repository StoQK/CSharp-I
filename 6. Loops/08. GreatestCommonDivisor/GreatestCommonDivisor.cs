//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers: ");
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int b = int.Parse(Console.ReadLine());
        int tmp;
        int gcd;
        Console.Write("The greatest common divisor between {0} and {1} is: ", a, b);
        if (a == 0 && b > 0)
        {
            gcd = b;
        }
        else if (b == 0 && a > 0)
        {
            gcd = a;
        }
        else if (a > 0 || b > 0)
        {
            while (b > 0)
            {
                tmp = b;
                b = a % b;
                a = tmp;
            }
            gcd = a;
            Console.WriteLine(gcd);
        }

    }
}
