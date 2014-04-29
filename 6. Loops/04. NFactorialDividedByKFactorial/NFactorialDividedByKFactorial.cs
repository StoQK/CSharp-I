//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class NFactorialDividedByKFactorial
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;
        if (n > k && k > 1)
        {
            for (int i = n; i > (n - k); i--)
            {
                result *= i;
            }
            Console.WriteLine("n!/k! = " + result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
