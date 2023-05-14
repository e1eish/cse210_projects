public class Menu
{    
    private Journal _journal = new Journal();
    private SaveLoadFile _fileLoader = new SaveLoadFile();
    public Menu()
    {

    }

    public void Display()
    {
        string response = "";
        string[] options = {"A","D","S","L","Q"};
        while(response!="Q")
        {
            while(options.Contains(response)==false)
            {
                Console.Write("[A]dd new entry\n[D]isplay journal\n[S]ave journal to file\n[L]oad journal from file\n[Q]uit\n\nWhat do you want to do? ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch (response)
            {
                case "Q":
                    Environment.Exit(0);
                    break;
                case "A":
                    Console.WriteLine();
                    _journal.AddEntry();
                    Console.WriteLine();
                    break;
                case "D":
                    Console.WriteLine();
                    _journal.DisplayJournal();
                    Console.WriteLine();
                    break;
                case "S":
                    Console.Write("\nEnter the name of the file to save to: ");
                    string filenameSaving = Console.ReadLine();

                    _fileLoader._content = _journal.ExportJournal();
                    _fileLoader.Save(filenameSaving);

                    Console.WriteLine("Saving complete\n");
                    break;
            case "L":
                Console.Write("\nEnter the name of the file to load from: ");
                string filenameLoading = Console.ReadLine();

                _journal.ImportJournal(_fileLoader.Load(filenameLoading));
                Console.WriteLine("Loading complete\n");
                break;
            }
            response = "";
        }
    }
}