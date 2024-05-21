using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;

    public Square(double side,string color)
    {
        _side=side;
        SetColor(color);
    }
    public override double GetArea()
    {
        return _side*4;
    }
}