public class MindfulnessAct
{
    private string _startMsg;
    private List<string> _endMsgs = new List<string>()
    {
        "Good Job.", 
        "Well Done!!"
    };
    private string _description;
    private int _countdown;

    public MindfulnessAct(string startMsg, string description, int countdown)
    {
        _startMsg = startMsg;
        _description = description;
        _countdown = countdown;
    }

    protected void DisplayStart()
    {
        Console.WriteLine(_startMsg);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    protected void DisplayEnd()
    {
        Random rand = new Random();
        int message = rand.Next(_endMsgs.Count - 1);
        
        Console.WriteLine(_endMsgs[message]);
    }

    protected void DisplaySpinner(int length)
    {
        List<string> animStrings = new List<string>();
        animStrings.Add("|");
        animStrings.Add("/");
        animStrings.Add("-");
        animStrings.Add("\\");
        animStrings.Add("|");
        animStrings.Add("/");
        animStrings.Add("-");
        animStrings.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(length);
        
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;

            if (i >= animStrings.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }

    protected void DisplayCountdown(int length)
    {
        for (int i = 0; i < length; i++)
            {
                Console.Write(length - i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }
}