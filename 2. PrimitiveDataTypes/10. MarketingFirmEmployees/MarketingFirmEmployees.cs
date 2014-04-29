using System;

class MarketingFirmEmployees
{
    static void Main()
    {
        
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter your family name: ");
        string familyName = Console.ReadLine();
        Console.Write("Please enter your age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Please enter your gender: M for male or F for female: ");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Please enter your id: ");
        long id = long.Parse(Console.ReadLine());
        Console.Write("Please enter your unique employee number: ");
        int employeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Employee information: \n{0} \n{1} \n{2} \n{3} \n{4} \n{5}", firstName, familyName, age, gender, id, employeeNumber);


    }
}
