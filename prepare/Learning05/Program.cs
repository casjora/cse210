using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(3,"black"));
        shapes.Add(new Rectangle("black",3,6));
        shapes.Add(new Circle("black",15));

        foreach(Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();

            Console.WriteLine($"The color is {color}, the area is {area}.");
        }

        Square sq = new Square(3,"green");
        Rectangle rc = new Rectangle("Red",4,2);
        Circle cr = new Circle("Black",10);
        Console.WriteLine($"Square");
        Console.WriteLine(sq.GetColor());
        Console.WriteLine(sq.GetArea());
        Console.WriteLine($"\n");
        Console.WriteLine($"Rectangle");
        Console.WriteLine(rc.GetColor());
        Console.WriteLine(rc.GetArea());
        Console.WriteLine($"\n");
        Console.WriteLine($"Circle");
        Console.WriteLine(cr.GetColor());
        Console.WriteLine(cr.GetArea());

        
    }
}