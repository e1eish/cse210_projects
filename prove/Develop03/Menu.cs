public class Menu
{
    private Scripture _scripture;

    public Menu(string verse, Reference reference)
    {
        _scripture = new Scripture(verse, reference);
    }

    public Menu(Scripture scripture)
    {
        _scripture = scripture;
    }

    public void Display()
    {
       Console.Write("Enter the percentage of hidden words: ");
       int percentage = int.Parse(Console.ReadLine() ?? String.Empty);
       
       string response = "";
       string[] options = {"QUIT", "S", "H"};
       while(response!="QUIT")
       {
            while(options.Contains(response)==false)
            {
                _scripture.HideWords(percentage);
                Console.Clear();
                Console.WriteLine(_scripture.Display());
                if (_scripture.AllHidden())
                {
                    Environment.Exit(0);
                }
                Console.Write("Press 'enter' to continue or type 'quit' to quit: ");
                response = Console.ReadLine().ToUpper() ?? String.Empty;
            }
            switch (response)
            {
                case "QUIT":
                    Environment.Exit(0);
                    break;
                case "S":
                    _scripture.ShowAll();
                    break;
                case "H":
                    _scripture.HideAll();
                    Environment.Exit(0);
                    break;
            }
            response = "";
       }
    }
}