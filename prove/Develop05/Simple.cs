public class Simple : Goal
{
    private bool _isComplete = false;

    public Simple(int points, string name, string description) : base(points, name, description)
    {

    }

    public Simple(int points, string name, string description, bool isComplete) : base(points, name, description)
    {
        _isComplete = isComplete;
    }

    public override int Record()
    {
        if (_isComplete)
        {
            Console.WriteLine("That goal is already complete.");
            return 0;
        } else {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {base.GetPoints()} points!");
            return base.Record();
        }
    }

    public override int GivePoints()
    {
        if (_isComplete)
        {
            return base.GivePoints();
        } else {
            return 0;
        }
    }

    public override bool CheckComplete()
    {
        return _isComplete;
    }

    public override string Display()
    {
        if (_isComplete)
        {
            return $"[X] {base.GetName()} ({base.GetDescription()})";
        } else {
            return $"[ ] {base.GetName()} ({base.GetDescription()})";
        }
    }
}