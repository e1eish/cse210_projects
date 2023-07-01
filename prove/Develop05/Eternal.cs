public class Eternal : Goal
{
    public Eternal(int points, string name, string description) : base(points, name, description)
    {

    }

    public override int Record()
    {
        Console.WriteLine($"Congratulations! You have earned {base.GetPoints()} points!");
        return base.Record();
    }

    public override string Display()
    {
        return $"[ ] {base.GetName()} ({base.GetDescription()})";
    }
}