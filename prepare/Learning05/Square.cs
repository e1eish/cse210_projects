public class Square : Shape
{
    private double _side;

    public Square(string colour, double side) : base(colour)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}