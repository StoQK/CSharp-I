using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i < 255; i++)
        {
            char character = (char)i;
            string hex = i.ToString("X4");
            Console.WriteLine("Decimal = {0}, ASCII = {1}, Hex = {2}", i, character, hex);
        }
    }
}
