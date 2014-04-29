/*
 Write a program that, depending on the user's choice inputs int, double or string variable. 
 If the variable is integer or double, increases it with 1. 
 If the variable is string, appends "*" at its end. 
 The program must show the value of that variable as a console output. Use switch statement. 
 */

using System;

class VariableConsoleOutput
{
    static void Main()
    {
        Console.Write("Please enter 1 for an integer variable, 2 for a double or 3 for string: ");
        string userInput = Console.ReadLine();
        byte userChoice;
        bool check = byte.TryParse(userInput, out userChoice);

        if (check && (userChoice == 1 || userChoice == 2 || userChoice == 3))
        {
            switch (userChoice)
            {
                case 1:
                    Console.Write("Enter your int variable: ");
                    long intChoice;
                    if (long.TryParse(Console.ReadLine(), out intChoice))
                    {
                        Console.WriteLine(intChoice + 1);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input! Please Try again!");
                        Main();
                    }
                    break;
                case 2:
                    Console.Write("Enter your double variable: ");
                    double doubleChoice;
                    if (double.TryParse(Console.ReadLine(), out doubleChoice))
                    {
                        Console.WriteLine(doubleChoice + 1.0);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input! Please Try again!");
                        Main();
                    }
                    break;
                case 3:
                    Console.Write("Enter your string variable: ");
                    string strChoice = Console.ReadLine();
                    Console.WriteLine(strChoice + "*");
                    break;
                default:
                    Console.WriteLine("Incorrect input! Please Try again!");
                    Main();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Incorrect input! Please Try again!");
            Main();
        }
    }
}