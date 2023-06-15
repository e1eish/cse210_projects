public class Circle : Shape
{
    private double _radius;

    public Circle(string colour, double radius) : base(colour)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.Round(2 * Math.PI * _radius, 2);
    }
}