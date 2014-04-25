using System;

class IsoscelesTriangleCopyrightSymbol
{
    static void Main()
    {
        char copyright = '\u00A9';
        Console.WriteLine(string.Format("{0,5}", copyright));
        Console.WriteLine(string.Format("{0,4} {1,1}", copyright, copyright));
        Console.WriteLine(string.Format("{0,3} {1,3}", copyright, copyright));
        Console.WriteLine(string.Format("{0,2} {1,1} {2,1} {3,1}", copyright, copyright, copyright, copyright));
    }
}
