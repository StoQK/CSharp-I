// In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
// (2n)! / (n+1)!n!
// Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;

class NCatalanNumber
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger nPlusOneFactorial = 1;
        BigInteger result;
        if (n >= 0)
        {
            for (int i = 2*n; i > n; i--)
            {
                nFactorial *= i;
            }
            for (int i = n + 1; i > 1; i--)
            {
                nPlusOneFactorial *= i;
            }
            result = nFactorial / nPlusOneFactorial;
            Console.WriteLine("The {0}th Catalan number is: {1} ", n, result);
        }
    }
}
