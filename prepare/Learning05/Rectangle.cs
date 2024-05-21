public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color,double len,double wid)
    {
        _length=len;
        _width=wid;
        SetColor(color);
    }

    public override double GetArea()
    {
        return _width* _length;
    }
}