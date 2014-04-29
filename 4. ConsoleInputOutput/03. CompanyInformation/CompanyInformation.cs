// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints them on the console.


using System;

class CompanyInformation
{
    static void Main()
    {
        Console.Write("Please enter the company's name: ");
        string companyName = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhoneNumberInput = Console.ReadLine();
        int companyPhoneNumber;
        if (int.TryParse(companyPhoneNumberInput, out companyPhoneNumber))
        {
            
        }
        else
        {
            Console.WriteLine("Invalid phone number");
        }
        Console.Write("Fax number: ");
        string faxInput = Console.ReadLine();
        int faxNumber;
        if (int.TryParse(faxInput, out faxNumber))
        {
            
        }
        else
        {
            Console.WriteLine("Invalid fax number");
        }
        Console.Write("Website: ");
        string website = Console.ReadLine();
        Console.Write("Manager's first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager's last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager's age: ");
        string ageInput = Console.ReadLine();
        byte age;
        if (byte.TryParse(ageInput, out age))
        {
            
        }
        else
        {
            Console.WriteLine("Invalid age");
        }
        Console.Write("Manager's phone number: ");
        string managerPhoneInput = Console.ReadLine();
        int managerPhoneNumber;
        if (int.TryParse(managerPhoneInput, out managerPhoneNumber))
        {
            
        }
        else
        {
            Console.WriteLine("Invalid phone number");
        }
        Console.WriteLine("Company name: {0} \nAddress: {1} \nPhone Number: {2} \nFax: {3} \nWebsite: {4}" +
                          "\n\nManager \nFirst name: {5} \nLast name: {6} \nAge: {7} \nPhone number: {8}", companyName, address, companyPhoneNumber, faxNumber, 
                          website, managerFirstName, managerLastName, age, managerPhoneNumber);
    }
}
