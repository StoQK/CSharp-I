using System;

class FibonacciSequenceSum
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal sequence = 0;
        decimal sum = 0;
        
        for (int i = 0; i < n; i++)
        {
            sequence = firstNumber;
            firstNumber = secondNumber;
            secondNumber += sequence;
            Console.Write("{0}, ", sequence);
            sum += sequence;
        }
        Console.WriteLine();
        Console.WriteLine("The sum of the first {0} elements of the Fibonacci sequence is: {1} ", n, sum);
        
    }
}
