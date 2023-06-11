public class Refleciton : MindfulnessAct
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Refleciton(string startMsg, string description, int countdown) : base(startMsg, description, countdown)
    {

    }

    private string GetPrompt()
    {
        var rand = new Random();
        string prompt = _prompts[rand.Next(0,_prompts.Count())];
        return prompt;
    }

    private string GetQuestion()
    {
        var rand = new Random();
        string question = _questions[rand.Next(0,_questions.Count())];
        return question;
    }

    public void Display()
    {
        Console.Clear();
        base.DisplayStart();
        Console.Write("How long, in seconds, would you like for your session? ");
        int length = int.Parse(Console.ReadLine() ?? String.Empty);
        RunExercise(length);
    }

    private void RunExercise(int length)
    {
        Console.Clear();
        RunExerciseIntro();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(length);

        DateTime currentTime = DateTime.Now;
        Console.Clear();
        while(currentTime < endTime)
        {
            Console.Write($"{GetQuestion()} ");
            base.DisplaySpinner(10);
            currentTime = DateTime.Now;
        }
        base.DisplayEnd();
        base.DisplaySpinner(2);
        Console.WriteLine($"\nYou have completed another {length} seconds of the Reflection Activity.");
        base.DisplaySpinner(5);
    }

    private void RunExerciseIntro()
    {
        Console.WriteLine("Get Ready...\n");
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {GetPrompt()} --- \n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        base.DisplayCountdown(5);
    }
}