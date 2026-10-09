using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5.0);
        Console.WriteLine($"Color: {square.GetColor()}, Area: {square.GetArea()}");


        List<Shape> shapes = new List<Shape>
        {
            new Square("Black", 3.0),
            new Rectangle("Green", 2.0, 8.0),
            new Circle("Red", 2.5),
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
        }
}