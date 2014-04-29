using System;

class DivisionWithoutRemainder
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(a % 35 == 0 ? "{0} is divisible by 5 and 7 without a remainder = True" : "{0} is divisible by 5 and 7 without a remainder = False", a);
    }
}
