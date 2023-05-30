using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;  

    public Reference(string book, int chapter,  int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = -1;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string getReference()
    {
        string reference;
        reference = ($"{_book} {_chapter}:{_verseStart.ToString()}");

        if (_verseEnd != -1)
        {
            reference = ($"{reference}-{_verseEnd.ToString()}");
        }

        return reference;
    }
}