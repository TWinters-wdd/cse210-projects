using System;

class Scripture
{
    private ScriptureReference _reference;

    private List<Word> _words;

    public Scripture()
    {
        _reference = new ScriptureReference();
        _words = new List<Word>();
    }

    public Scripture(ScriptureReference reference, string verse)
    {
        _reference = reference;
        _words = ConvertToList(verse);
    }

    public bool HideRandomWords()
    {
        int verseLength = _words.Count();
        Random randomWord = new Random();

        for (int i = 0; i < 3; i++)
        {
            int index = randomWord.Next(verseLength);

            _words[index].Hide();
        }
       
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{_reference.GetScriptureReference()}");
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetWordString()} ");
        }
    }

    private List<Word> ConvertToList(string verse)
    {
        List<Word> newList = new List<Word>();
        string[] wordArray = verse.Split(' ');
        
        foreach(string item in wordArray)
        {
            Word tempWord = new Word(item);
            newList.Add(tempWord);
        }

        return newList;
    }
}