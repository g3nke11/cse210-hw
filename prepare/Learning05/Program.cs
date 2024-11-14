using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Red", 3));
        shapes.Add(new Rectangle("blue", 4, 3));
        shapes.Add(new Circle("Yellow", 5));
        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}