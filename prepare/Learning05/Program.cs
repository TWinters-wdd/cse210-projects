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

        Console.WriteLine("");

        Circle myCircle = new Circle("Pink", 2);
        Console.WriteLine(myCircle.GetColor());
        Console.WriteLine(myCircle.GetArea());

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(mySquare);
        shapeList.Add(myRectangle);
        shapeList.Add(myCircle);

        Console.WriteLine("\nList of Shapes:");
        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}