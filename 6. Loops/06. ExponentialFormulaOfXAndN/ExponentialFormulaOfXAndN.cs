//Write a program that, for given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;
using System.Numerics;

class ExponentialFormulaOfXAndN
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x=");
        int x = int.Parse(Console.ReadLine());
        BigInteger sum = 1;
        BigInteger nFactorial = 1;
        BigInteger xPow = 1;
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            xPow *= x;
            // xPow = (double)Math.Pow(x, i);
            sum = sum + (nFactorial / xPow);
        }
        Console.WriteLine("For n = {0}, x = {1}, sum = {2}", n, x, sum);
    }
}
