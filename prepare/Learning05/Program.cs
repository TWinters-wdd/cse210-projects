using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("Purple", 10);

        Console.WriteLine(mySquare.GetColor());
        Console.WriteLine(mySquare.GetArea());
    }
}