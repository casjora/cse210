public class Circle : Shape
{
    private double _radius;

        public Circle(string color,double rad)
    {
        _radius=rad;
        SetColor(color);
    }

    public override double GetArea()
    {
        return Math.PI*_radius;
    }
}