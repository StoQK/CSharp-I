// Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class GreaterValueInteger
{
    static void Main()
    {
        Console.WriteLine("Please enter two integers on a separate line: ");

        int smallerInteger = int.Parse(Console.ReadLine());
        int biggerInteger = int.Parse(Console.ReadLine());
        if (biggerInteger < smallerInteger)
        {
            biggerInteger = smallerInteger;
            Console.WriteLine("The bigger of the two integers is: " + biggerInteger);
        }
        else
        {
            Console.WriteLine("The bigger of the two integers is: " + biggerInteger);
        }
    }
}
