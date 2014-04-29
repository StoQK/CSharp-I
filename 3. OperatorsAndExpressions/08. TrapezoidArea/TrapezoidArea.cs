using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Please enter side a: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Please enter side b: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Please enter height: ");
        double height = double.Parse(Console.ReadLine());

        double trapezoidArea = (sideA + sideB) * 0.5 * height;
        Console.WriteLine("The area of the trapezoid is: {0}", trapezoidArea);
    }
}
