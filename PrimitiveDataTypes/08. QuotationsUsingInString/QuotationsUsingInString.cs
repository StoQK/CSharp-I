using System;

class QuotationsUsingInString
{
    static void Main()
    {
        string unQuotedString = "The \"use\" of quotations causes difficulties";
        Console.WriteLine(unQuotedString);
        string quotedString = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(quotedString);
    }
}
