using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Please enter the point coordinates: ");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if (x*x + y*y <= 25)
        {
            Console.WriteLine("Point with coordinates ({0},{1}) is within the circle with radius 5", x, y);
        }
        else
        {
            Console.WriteLine("Point with coordinates ({0},{1}) is not within the circle with radius 5", x, y);
        }
    }
}
