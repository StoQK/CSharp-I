//Write a program that reads 3 integer numbers from the console and prints their sum.


using System;

class SumOfThreeIntegers
{
    static void Main()
    {
        Console.Write("Please enter the first integer: ");
        string firstInput = Console.ReadLine();
        int firstInteger, secondInteger, thirdInteger;
        
        if (int.TryParse(firstInput, out firstInteger))
        {
            Console.Write("Please enter the second integer value: ");
            string secondInput = Console.ReadLine();
            if (int.TryParse(secondInput, out secondInteger))
            {
                Console.Write("Please enter the third integer value: ");
                string thirdInput = Console.ReadLine();
                if (int.TryParse(thirdInput, out thirdInteger))
                {
                    int sum = firstInteger + secondInteger + thirdInteger;
                    Console.WriteLine("The sum of the three integers is: {0}", sum);
                }
                else
                {
                    Console.WriteLine("Invalid integer value!");
                }
            }
            else
            {
                Console.WriteLine("Invalid integer value!");
            }
            
        }
        else
        {
            Console.WriteLine("Invalid integer value!");
        }
    }
}
