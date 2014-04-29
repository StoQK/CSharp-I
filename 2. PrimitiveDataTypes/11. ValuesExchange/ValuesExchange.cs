using System;

class ValuesExchange
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;
        Console.WriteLine("Value of a: {0}", a);
        Console.WriteLine("Value of b: {0}", b);
        byte c = (byte)(a + b);
        a = (byte)(c - a);
        b = (byte)(c - b);
        Console.WriteLine("New value of a: {0}", a);
        Console.WriteLine("New value of b: {0}", b);
    }
}
