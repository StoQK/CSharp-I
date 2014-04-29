//* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
//    N = 10 -> N! = 3628800 -> 2
//    N = 20 -> N! = 2432902008176640000 -> 4

using System;
using System.Numerics;

class TrailingZeroesFactorial
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        int trailingZeroes = 0;
        int divider = 5;
        for (int i = n; i > 1; i--)
        {
            nFactorial *= i;
            while (divider <=n)
            {
                trailingZeroes = trailingZeroes + (n / divider);
                divider *= 5;
            }
        }
        Console.WriteLine("n! = " + nFactorial);
        Console.WriteLine("Number of trailing zeroes = " + trailingZeroes);
    }
}
