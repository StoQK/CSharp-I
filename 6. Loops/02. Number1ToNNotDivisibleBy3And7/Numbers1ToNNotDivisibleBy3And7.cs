//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class Numbers1ToNNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            if (i % (3 * 7) == 0)
            {
                continue;
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
