using System;

class NullIntegerDoubleValues
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("This is the integer with null value-> " + a);
        Console.WriteLine("This is the double with null value-> " + b);
        a = a + null;
        Console.WriteLine("Null + null-> {0}", a.GetValueOrDefault());
        Console.WriteLine("Does integer 'a' have a value: " + a.HasValue);
        a = 5 + null; // The compiler tells us that the value of 'a' defined like that will always be null
        Console.WriteLine("Integer + null-> " + a.GetValueOrDefault());
        Console.WriteLine("Does integer 'a' have a value: " + a.HasValue);
        b = 3.14 + null;
        Console.WriteLine("Double + null-> " + b.GetValueOrDefault());
        Console.WriteLine("Does double 'b' have a value: " + b.HasValue);
        a = 5;
        b = 3.14 + 2.18;
        Console.WriteLine("Integer = " + a.GetValueOrDefault());
        Console.WriteLine("Double = " + b.GetValueOrDefault());
       
        
    }
}
