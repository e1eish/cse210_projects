public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse = -1;

    public Reference(string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
    }

    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    public string Display()
    {
        if (_lastVerse != -1)
        {
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        } else {
            return $"{_book} {_chapter}:{_firstVerse}";
        }
    }
}