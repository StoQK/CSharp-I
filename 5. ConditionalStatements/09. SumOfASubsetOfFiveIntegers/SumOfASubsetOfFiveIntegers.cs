﻿// We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

using System;

class SumOfASubsetOfFiveIntegers
{
        static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fourth number:");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the sixth number:");
        int e = int.Parse(Console.ReadLine());

        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}, {3}, {4}", a, b, c, d, e);
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}, {3} ", b, c, d, e);
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}, {3} ", a, c, d, e);
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}, {3} ", a, b, d, e);
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}, {3} ", a, b, c, e);
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}, {3} ", a, b, c, d);
        }

        if (c + d + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2} ", c, d, e);
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2} ", b, d, e);
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2} ", a, d, e);
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2} ", b, c, e);
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2} ", a, c, e);
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2} ", a, b, e);
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2} ", b, c, d);
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2} ", a, c, d);
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2} ", a, b, d);
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2} ", a, b, c);
        }
 
        if (d + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1} ", d, e);
        }
        if (c + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1} ", c, e);
        }
        if (b + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1} ", b, e);
        }
        if (a + e == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1} ", a, e);
        }
        if (c + d == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1} ", c, d);
        }
        if (b + d == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1} ", b, d);
        }
        if (a + d == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1} ", a, d);
        }
        if (b + c == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1} ", b, c);
        }
        if (a + c == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1} ", a, c);
        }
        if (a + b == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1} ", a, b);
        }
        else
        {
            Console.WriteLine("No subset has a sum of zero");
        }
    }
}
