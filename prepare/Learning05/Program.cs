using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>()
        {
            new Square("blue", 5),
            new Rectangle("red", 3, 4),
            new Circle("green", 5)
        };
        
        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColour());
            Console.WriteLine(shape.GetArea());
        }
    }
}