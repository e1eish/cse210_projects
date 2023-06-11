public class Breathing : MindfulnessAct
{
    public Breathing(string startMsg, string description, int countdown) : base(startMsg, description, countdown)
    {

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
        Console.WriteLine("Get Ready...");
        base.DisplaySpinner(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(length);
        
        DateTime currentTime = DateTime.Now;
        while(currentTime < endTime)
        {
            Console.Write("Breathe in...");
            base.DisplayCountdown(3);

            Console.Write("\nBreathe out...");
            base.DisplayCountdown(6);
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
        }
        base.DisplayEnd();
        Console.WriteLine($"\nYou have completed another {length} seconds of the Breathing Activity.");
        base.DisplaySpinner(5);
    }
}