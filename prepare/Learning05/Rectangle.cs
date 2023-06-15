public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string colour, double length, double width) : base(colour)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}