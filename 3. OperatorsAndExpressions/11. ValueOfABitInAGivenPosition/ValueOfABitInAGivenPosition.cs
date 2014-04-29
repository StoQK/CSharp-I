using System;

class ValueOfABitInAGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter the integer you want to check for: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Please enter the position of the bit you want to check for: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int iAndMask = i & mask;
        int bitValue = iAndMask >> b;
        Console.WriteLine("The value of the bit at position {0} is: {1}", b, bitValue);
    }
}
