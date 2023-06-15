public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void DisplayJournal()
    {
        Console.Clear();
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.Display());
        }
    }

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.GetResponse();
        _entries.Add(entry);
    }

    public void SearchByPrompt(string prompt)
    {
        foreach (Entry entry in _entries)
        {
            if (entry.HasPrompt(prompt))
            {
                Console.WriteLine(entry.Display());
            }
        }
    }

    public List<string> ExportJournal()
    {
        List<string> exportedJournal = new List<string>();
        foreach (Entry entry in _entries)
        {
            exportedJournal.Add($"{entry._prompt}|{entry._response}|{entry._date}|{entry.ReturnCharacterCount()}");
        }
        return exportedJournal;
    }

    public void ImportJournal(List<string[]> content)
    {
        List<Entry> newEntries = new List<Entry>();
        foreach (string[] entry in content)
        {
            Entry newEntry = new Entry();
            newEntry._prompt = entry[0];
            newEntry._response = entry[1];
            newEntry._date = DateTime.Parse(entry[2]);

            newEntries.Add(newEntry);
        }
        _entries = newEntries;
    }
}