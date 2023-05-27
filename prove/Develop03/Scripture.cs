public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _ref;

    public Scripture(string verse, Reference reference)
    {
        _words = ConvertStringToList(verse);
        _ref = reference;
    }

    private List<Word> ConvertStringToList(string newString)
    {
        List<Word> finalWords = new List<Word>();
        string[] stringList = newString.Split(" ");
        foreach (string singleWord in stringList)
        {
            Word word = new Word(singleWord);
            finalWords.Add(word);
        }
        return finalWords;
    }

    public string Display()
    {
        string words = "";
        foreach (Word word in _words)
        {
            words = words + " " + word.Display();
        }
        words = words.Trim();
        return $"{_ref.Display()} -\n{words}";
    }

    public void HideAll()
    {
        foreach (Word word in _words)
        {
            word.HideWord();
        }
    }

    public bool AllHidden()
    {
        int unhiddenCount = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden()==false)
            {
                unhiddenCount += 1;
            }
        }
        if (unhiddenCount<=(_words.Count()*0.1))
        {
            HideAll();
            return true;
        } else {
            return false;
        }
    }

    public void ShowAll()
    {
        foreach (Word word in _words)
        {
            word.ShowWord();
        }
    }

    public void HideWords(int percentage = 20)
    {
        Random rand = new Random();
        foreach (Word word in _words)
        {
            if (rand.Next(100) < percentage)
            {
                word.HideWord();
            }
        }
        AllHidden();
    }
}