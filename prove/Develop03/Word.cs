using System.Collections.Generic;

public class Word
{
    private string _word;
    private bool _isHidden = false;
    private string _hiddenWord;

    public Word(string word)
    {
        _word = word;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public void ShowWord()
    {
        _isHidden = false;
    }

    public string Display()
    {
        if (_isHidden)
        {
            List<char> newWord = new List<char>();
            foreach (char letter in _word)
            {
                if (Char.IsLetter(letter))
                {
                    newWord.Add('_');
                } else {
                    newWord.Add(letter);
                }
            }
            _hiddenWord = string.Join("", newWord);
            return _hiddenWord;
        } else {
            return _word;
        }
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}