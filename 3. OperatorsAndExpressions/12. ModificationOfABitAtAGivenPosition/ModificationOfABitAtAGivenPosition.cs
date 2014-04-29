using System;

class ModificationOfABitAtAGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter the integer you want to check for: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the position of the bit you want to check for: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter the value for the bit (0 or 1) at position p: ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        if (v == 1)
        {
            n = n | mask;
            Console.WriteLine("The new value of the integer n is: {0} ", n);
        }
        else if (v == 0)
        {
            int nAndMask = n & mask;
            n = n ^ nAndMask;
            Console.WriteLine("The new value of the integer n is: {0} ", n);
        }
        else
        {
            Console.WriteLine("Not a valid value for the bit!");
        }
        
    }
}
