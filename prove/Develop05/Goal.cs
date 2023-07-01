public class Goal
{
    private int _points;
    private string _name;
    private string _description;

    public Goal(int points, string name, string description)
    {
        _points = points;
        _name = name;
        _description = description;
    }

    public virtual int Record()
    {
        return _points;
    }

    public virtual int GivePoints()
    {
        return _points;
    }

    public virtual string Display()
    {
        return $"{_name} ({_description})";
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual string GetGoalType()
    {
        return "goal";
    }

    public virtual bool CheckComplete()
    {
        return false;
    }
    public virtual int GetTimesToComplete()
    {
        return 1;
    }
    
    public virtual int GetBonusPoints()
    {
        return 0;
    }

    public virtual int GetTimesComplete()
    {
        return 0;
    }
}