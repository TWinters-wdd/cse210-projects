using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("Purple", 10);

        Console.WriteLine(mySquare.GetColor());
        Console.WriteLine(mySquare.GetArea());

        Console.WriteLine("");

        Rectangle myRectangle = new Rectangle("Orange", 30, 5);
        Console.WriteLine(myRectangle.GetColor());
        Console.WriteLine(myRectangle.GetArea());
    }
}