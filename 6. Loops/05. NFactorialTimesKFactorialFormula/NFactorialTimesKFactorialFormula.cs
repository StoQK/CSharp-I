//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class NFactorialTimesKFactorialFormula
{
    static void Main()
    {
        Console.Write("k=");
        string userInputK = Console.ReadLine();
        int k;
        Console.Write("n=");
        string userInputN = Console.ReadLine();
        int n;
        BigInteger kMinusNFactorial = 1;
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        if (int.TryParse(userInputK, out k) && int.TryParse(userInputN, out n))
        {
            if (k > n && n > 1)
            {
                for (int i = 1; i <= (k - n); i++)
                {
                    kMinusNFactorial *= i;
                }
                for (int i = n; i > 1; i--)
                {
                    nFactorial *= i;
                }
                for (int i = k; i > 1; i--)
                {
                    kFactorial *= i;
                }
                BigInteger result = (nFactorial * kFactorial) / kMinusNFactorial;
                Console.WriteLine("N!*K! / (K-N)! = {0}", result);
            }
            else
            {
                Console.WriteLine("Please enter integers for k and n, where 1<n<k");
                Main();
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter integers:");
            Main();
        }
    }
}
