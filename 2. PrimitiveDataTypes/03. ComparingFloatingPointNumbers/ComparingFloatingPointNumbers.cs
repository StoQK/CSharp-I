using System;

class ComparingFloatingPointNumbers
{
    static void Main()
    {
        float a = 5.3f;
        float b = 6.01f;
        bool isBigger = a > b;
        Console.WriteLine("{0} is bigger than {1}: {2}", a, b, isBigger);

        double c = 5.00000001;
        double d = 5.00000003;
        Console.WriteLine("{0} is bigger than {1}: {2}", d, c, d > c);
    }
}
