using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        // *First solution*

        Console.Write("Please enter an integer greater than 1000: ");
        int initialValue = int.Parse(Console.ReadLine());
        double afterDividedByHundred = initialValue / 100;
        double thirdDigit = afterDividedByHundred % 10;
        Console.WriteLine(thirdDigit % 7 == 0 ? "the third digit of the integer is 7" : "the third digit of the integer is not 7");

        // *Second solution*

        Console.Write("Please enter an integer: ");
        string number = Console.ReadLine();
        if (number[number.Length - 3] == '7')
        {
            Console.WriteLine("The third digit in the number is 7");
        }
        else
        {
            Console.WriteLine("The third digit in the number is different from 7");
        }

    }
}
