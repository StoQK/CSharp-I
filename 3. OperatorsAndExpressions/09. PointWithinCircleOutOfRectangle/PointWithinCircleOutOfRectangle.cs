using System;

class PointWithinCircleOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter the point coordinates: ");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        if ((x-1) * (x-1) + (y-1) * (y-1) <= 9)
        {
            Console.WriteLine("Point with coordinates ({0},{1}) is within the circle with coordinates ((1, 1), 3)", x, y);
            if ((x < -1 || x > 5) || (y > 1 || y < -1))
            {
                Console.WriteLine("Point with coordinates ({0},{1}) is outside the rectangle", x, y);
            }
            else if ((x > -1 || x < 5) && (y < 1 || y > -1))
            {
                Console.WriteLine("Point with coordinates ({0},{1}) is inside the rectangle", x, y);
            }
        }
        else
        {
            Console.WriteLine("Point with coordinates ({0},{1}) is outside the circle with coordinates ((1, 1), 3)", x, y);
            if ((x < -1 || x > 5) || (y > 1 || y < -1))
            {
                Console.WriteLine("Point with coordinates ({0},{1}) is outside the rectangle", x, y);
            }
            else if ((x > -1 || x < 5) && (y < 1 || y > -1))
            {
                Console.WriteLine("Point with coordinates ({0},{1}) is inside the rectangle", x, y);
            }
        }
    }
}
