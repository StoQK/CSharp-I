using System;

class OutputATextFileOnConsole
{
    static void Main()
    {
        System.Diagnostics.Process.Start(@"C:\Users\Stoyan\Desktop\AlaBala.txt"); // Won't be able to run on any other pc, due to the file missing
    }
}
