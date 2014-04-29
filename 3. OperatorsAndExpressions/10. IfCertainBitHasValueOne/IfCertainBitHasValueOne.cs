using System;

class IfCertainBitHasValueOne
{
    static void Main()
    {
        Console.Write("Please enter the integer you want to check for: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Please enter the position of the bit you want to check for: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int vAndMask = v & mask;
        int bitAtP = vAndMask >> p;
        if (bitAtP == 1)
        {
            Console.WriteLine("The bit at position P is 1");
        }
        else
        {
            Console.WriteLine("The bit at position p is 0");
        }
    }
}
