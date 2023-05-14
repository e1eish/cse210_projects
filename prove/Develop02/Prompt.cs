public class Prompt
{
    List<string> _prompt = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What scares you? - Sunday Scribblings",
        "Do you have a plan? Do you need a plan? Have you had a plan fall spectacularly to pieces? - Sunday Scribblings",
        "Are you a worrier? Is there a particular worry that you can't shake? How do you cope with worry? - Sunday Scribblings",
        "\"If your daily life seems poor, do not blame it; tell yourself that you are not poet enough to call forth its riches\" - Rilke",
        "\"Art is when you hear knocking from your soul and you answer.\" - Star Richés"
    };

    public Prompt()
    {

    }

    public void AddList(List<string> prompts)
    {
        _prompt.Concat(prompts);
    }

    public string PickRandomPrompt()
    {
        var random = new Random();
        string randomPrompt = _prompt[random.Next(0,_prompt.Count())];
        return randomPrompt;
    }

    public void DisplayPrompts()
    {
        foreach(string prompt in _prompt)
        {
            Console.WriteLine(prompt);
        }
    }
}