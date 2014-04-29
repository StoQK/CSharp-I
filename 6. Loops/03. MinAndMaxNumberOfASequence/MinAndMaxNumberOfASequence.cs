//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinAndMaxNumberOfASequence
{
    static void Main()
    {
        // *First Solution*

        Console.Write("How many numbers would you like to input:");
        int n = int.Parse(Console.ReadLine());
        int[] sequence = new int[n];
        for (int i = 0; i < sequence.Length; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }
        int maxValue = sequence[0];
        int minValue = sequence[0];
        foreach (int number in sequence)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
            if (number < minValue)
            {
                minValue = number;
            }
        }
        Console.WriteLine("Biggest number: {0} \nSmallest number: {1} ", maxValue, minValue);

        // *Second Solution*
        Console.WriteLine();
        Console.Write("m=");
        int m = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        for (int i = 0; i < m; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input > max)
            {
                max = input;
            }
            if (input < min)
            {
                min = input;
            }
        }
        Console.WriteLine("max: {0} \nmin: {1}", max, min);
    }
}
