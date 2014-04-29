using System;

class IsBitThreeOneOrZero
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int nAndMask = n & mask;
        int thirdBit = nAndMask >> p;
        if (thirdBit == 1)
        {
            Console.WriteLine("The third bit of the integer is 1");
        }
        else
        {
            Console.WriteLine("The third bit of the integer is 0");
        }

    }
}
