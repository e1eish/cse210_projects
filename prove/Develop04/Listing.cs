public class Listing : MindfulnessAct
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _items = new List<string>();

    public Listing(string startMsg, string description, int countdown) : base(startMsg, description, countdown)
    {

    }

    private string GetPrompt()
    {
        var rand = new Random();
        string prompt = _prompts[rand.Next(0,_prompts.Count())];
        return prompt;
    }

    private string GetResponse()
    {
        Console.Write("> ");
        string response = Console.ReadLine() ?? String.Empty;
        return response;
    }

    public void Display()
    {
        Console.Clear();
        base.DisplayStart();
        Console.Write("How long, in seconds, would you like for your session? ");
        int length = int.Parse(Console.ReadLine() ?? String.Empty);
        _items.Clear();
        RunExercise(length);
    }

    private void RunExercise(int length)
    {
        Console.Clear();
        Console.WriteLine("Get ready...\n");
        Thread.Sleep(250);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetPrompt()} --- ");
        Console.Write("You may begin in: ");
        base.DisplayCountdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(length);

        while (DateTime.Now < endTime)
        {
            _items.Add(GetResponse());
        }
        Console.WriteLine($"You listed {_items.Count} items!\n");

        base.DisplayEnd();
        Console.WriteLine($"\nYou have completed another {length} seconds of the Listing Activity.");
        base.DisplaySpinner(5);
    }
}