public class Entry {
    public DateTime _date = DateTime.Now;
    public string _response;
    public string _prompt;
    private int _responseLength;

    public Entry()
    {
        Prompt prompt = new Prompt();
        _prompt = prompt.PickRandomPrompt();
    }

    public void GetResponse()
    {
        Console.WriteLine(_prompt);
        Console.Write("Please enter your response: ");
        _response = Console.ReadLine() ?? String.Empty;
        _responseLength = _response.Count();
    }

    public string Display()
    {
        return "-----------------------------\n" + 
        _prompt + "\n" + 
        _response + " - " + 
        _date.ToString("dd/MM/yyyy") + " " + _date.ToString("H:mm tt") +
        "\n-----------------------------";
    }

    public bool HasPrompt(string prompt)
    {
        return prompt == _prompt;
    }

    public int ReturnCharacterCount()
    {
        return _responseLength;
    }
}