//Write a program that finds the greatest of given 5 variables.

using System;

class GreatestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter five numbers: ");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double forthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());
        double biggestNumber = firstNumber;
        if (biggestNumber < secondNumber)
        {
            biggestNumber = secondNumber;
        }
        if (biggestNumber < thirdNumber)
        {
            biggestNumber = thirdNumber;
        }
        if (biggestNumber < forthNumber)
        {
            biggestNumber = forthNumber;
        }
        if (biggestNumber < fifthNumber)
        {
            biggestNumber = fifthNumber;
        }
        Console.WriteLine("The biggest number is: " + biggestNumber);
    }
}