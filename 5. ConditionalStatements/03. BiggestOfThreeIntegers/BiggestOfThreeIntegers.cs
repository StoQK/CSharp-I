//Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestOfThreeIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 integers, each one on a separate line: ");
        int firstInteger = int.Parse(Console.ReadLine());
        int secondInteger = int.Parse(Console.ReadLine());
        int thirdInteger = int.Parse(Console.ReadLine());
        if (firstInteger > secondInteger)
        {
            if (firstInteger > thirdInteger)
            {
                Console.WriteLine("The biggest integer is: " + firstInteger);
            }
            else if (thirdInteger > firstInteger)
            {
                Console.WriteLine("The biggest integer is: " + thirdInteger);
            }
        }
        else if (secondInteger > firstInteger)
        {
            if (secondInteger > thirdInteger)
            {
                Console.WriteLine("The biggest integer is: " + secondInteger);
            }
            else if (secondInteger < thirdInteger)
            {
                Console.WriteLine("The biggest integer is: " + thirdInteger);
            } 
        }
        else if (thirdInteger > firstInteger)
        {
            if (thirdInteger > secondInteger)
            {
                Console.WriteLine("The biggest integer is: " + thirdInteger);
            }
            else if (thirdInteger < secondInteger)
            {
                Console.WriteLine("The biggest integer is: " + secondInteger);
            }
        }
        else
        {
            Console.WriteLine("The biggest value is entered more than once");
        }
    }
}
