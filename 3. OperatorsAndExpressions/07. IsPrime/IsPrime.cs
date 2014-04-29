using System;

class IsPrime
{
    static void Main()
    {
        Console.Write("Please enter an integer in the interval [0, 100]: ");
        int x = int.Parse(Console.ReadLine());
        if (x == 2)
        {
            Console.WriteLine("{0} is prime! ", x);
        }
        int maxDivider = (int)Math.Sqrt(x);
        for (int i = 2; i <=maxDivider; i++)
        {
            if (x % i == 0)
            {
                Console.WriteLine("{0} is not prime!", x);
            }
            else
            {
                Console.WriteLine("{0} is prime!", x);
            }
        }
    }
}
