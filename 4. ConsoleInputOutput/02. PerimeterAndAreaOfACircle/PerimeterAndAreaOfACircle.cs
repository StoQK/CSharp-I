// Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class PerimeterAndAreaOfACircle
{
    static void Main()
    {
        Console.Write("Please enter the radius of the circle: ");
        double radius;
        string userInput = Console.ReadLine();
        double circleArea;
        double circlePerimeter;
        if (double.TryParse(userInput, out radius))
        {
            circleArea = Math.PI * radius * radius;
            circlePerimeter = 2 * Math.PI * radius;
            Console.WriteLine("The perimeter and the area of the circle with radius {0} are: ", radius);
            Console.WriteLine("Perimeter: {0} \nArea: {1} ", circlePerimeter, circleArea);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
