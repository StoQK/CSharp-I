using System;

class SquaredNumber
{
    static void Main()
    {
        int numberToSquare = 12345;
        double squaredNumber = Math.Pow(numberToSquare, 2);
        Console.WriteLine("The square of {0} is {1}", numberToSquare, squaredNumber);
    }
}
