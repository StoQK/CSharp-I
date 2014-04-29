using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Please enter your age: ");
        int yourAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age after 10 years would be: " + (yourAge + 10));
    }
}
