using System;

class FloatAndDoubleVariableTypes
{
    static void Main()
    {
        double a = 34.567839023;
        Console.WriteLine("The number " + a + @" should be declared as a double data type,
because it contains 11 numbers and not 7,
which is the precision of the float data type.
");
        float b = 12.345f;
        Console.WriteLine("The number {0} can be assigned to a float data type, without losing precision \n", b);

        double c = 8923.1234857;
        Console.WriteLine("The number {0} should be assigned as a double data type in order not to lose precision \n", c);

        float d = 3456.091f;
        Console.WriteLine("The number {0} can be assigned as a float data type, bacause it has 7 numbers as the precision of float \n", d);
    }
}
