public class Checklist : Goal
{
    private int _goalAmount;
    private int _bonusValue;
    private bool _isComplete = false;
    private int _timesComplete = 0;

    public Checklist(int points, string name, string description, int goalAmount, int bonusValue) : base(points, name, description)
    {
        _goalAmount = goalAmount;
        _bonusValue = bonusValue;
    }

    public Checklist(int points, string name, string description, int goalAmount, int bonusValue, int timesComplete) : base(points, name, description)
    {
        _goalAmount = goalAmount;
        _bonusValue = bonusValue;
        _timesComplete = timesComplete;
        if (_timesComplete == _goalAmount)
        {
            _isComplete = true;
        }
    }

    public override int Record()
    {
        if (_isComplete)
        {
            Console.WriteLine("That goal is already complete.");
            return 0;
        } else {
            _timesComplete += 1;
            if (_timesComplete == _goalAmount)
            {
                _isComplete = true;
                Console.WriteLine($"Congratulations! You have earned {base.GetPoints() + _bonusValue} points!");
                return base.Record() + _bonusValue;
            } else {
                Console.WriteLine($"Congratulations! You have earned {base.GetPoints()} points!");
                return base.Record();
            }
        }
    }

    public override string Display()
    {
        if (_isComplete)
        {
            return $"[X] {base.GetName()} ({base.GetDescription()})";
        } else {
            return $"[ ] {base.GetName()} ({base.GetDescription()}) -- Currently completed: {_timesComplete}/{_goalAmount}";
        }
    }

    public override int GetTimesComplete()
    {
        return _timesComplete;
    }

    public override int GetTimesToComplete()
    {
        return _goalAmount;
    }

    public override int GetBonusPoints()
    {
        return _bonusValue;
    }
}