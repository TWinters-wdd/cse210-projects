using System;

class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public ScriptureReference()
    {
        _book = "John";
        _chapter = 3;
        _startVerse = 16;
        _endVerse = -1;
    }

    public ScriptureReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = -1;
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetScriptureReference()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}"; 
        }
    }
}