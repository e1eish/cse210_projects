public class User
{
    private string _name;
    private int _score;
    private List<Goal> _goals = new List<Goal>();

    private int _level = 0;

    public User(string name)
    {
        _name = name;
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i ++)
        {
            Console.WriteLine($" {i+1}. {_goals[i].GetName()}");
        }
        Console.Write("What goal do you wish to accomplish? ");
        int response = int.Parse(Console.ReadLine() ?? String.Empty) - 1;
        _score += _goals[response].Record();
        Console.WriteLine($"You now have {_score} points.");

        decimal scoreDouble = _score;
        scoreDouble = scoreDouble / 50;
        int newLevel = Convert.ToInt32(Math.Round(scoreDouble));
        _level = newLevel;
    }

    public void AddGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine() ?? String.Empty);

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine() ?? String.Empty;

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine() ?? String.Empty;

        Console.Write("What is the amount of points associated with this goal? ");
        int goalValue = int.Parse(Console.ReadLine() ?? String.Empty);

        if (goalType == 1)
        {
            _goals.Add(new Simple(goalValue, goalName, goalDescription));
        } else if (goalType == 2) {
            _goals.Add(new Eternal(goalValue, goalName, goalDescription));
        } else if (goalType == 3) {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int timesToComplete = int.Parse(Console.ReadLine() ?? String.Empty);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusValue = int.Parse(Console.ReadLine() ?? String.Empty);
            
            _goals.Add(new Checklist(goalValue, goalName, goalDescription, timesToComplete, bonusValue));
        }
    }

    public void Display()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($" {i+1}. {_goals[i].Display()}");
        }
    }

    public int GetScore()
    {
        return _score;
    }


    public int GetLevel()
    {
        return _level;
    }

    public List<string> ExportGoals()
    {
        List<string> exportedGoals = new List<string>();
        exportedGoals.Add(_score.ToString());
        foreach (Goal goal in _goals)
        {
            if (goal.GetType().ToString() == "Simple")
            {
                exportedGoals.Add($"{goal.GetType().ToString()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.CheckComplete()}");
            } else if (goal.GetType().ToString() == "Eternal") {
                exportedGoals.Add($"{goal.GetType().ToString()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}");
            } else if (goal.GetType().ToString() == "Checklist") {
                exportedGoals.Add($"{goal.GetType().ToString()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetBonusPoints()}|{goal.GetTimesToComplete()}|{goal.GetTimesComplete()}");
            }
        }
        return exportedGoals;
    }

    public void ImportGoals(List<string[]> content)
    {
        List<Goal> newGoals = new List<Goal>();
        _score = int.Parse(content[0][0]);
        for (int i = 1; i < content.Count(); i++)
        {
            if (content[i][0] == "Simple")
            {
                Simple newSimple = new Simple(int.Parse(content[i][3]), content[i][1], content[i][2], Boolean.Parse(content[i][4]));
                newGoals.Add(newSimple);
            } else if (content[i][0] == "Eternal") {
                Eternal newEternal = new Eternal(int.Parse(content[i][3]), content[i][1], content[i][2]);
                newGoals.Add(newEternal);
            } else if (content[i][0] == "Checklist") {
                Checklist newChecklist = new Checklist(int.Parse(content[i][3]), content[i][1], content[i][2], int.Parse(content[i][5]), int.Parse(content[i][4]), int.Parse(content[i][6]));
                newGoals.Add(newChecklist);
            }
        }
        _goals = newGoals;
    }
}