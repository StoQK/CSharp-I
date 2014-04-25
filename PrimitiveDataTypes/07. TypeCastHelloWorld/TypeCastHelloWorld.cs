using System;

class TypeCastHelloWorld
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object helloWorldObject = hello + " " + world;
        string helloWorldString = (string)helloWorldObject;
    }
}
