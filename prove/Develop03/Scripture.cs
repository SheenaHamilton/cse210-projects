using System;

class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _scriptureReference;
    private Random _randomIndex = new Random();
    private int _wordsRemainging = 0;

    public Scripture(string verse, string book, int chapter, int verseStart, int verseEnd = -1){

        string[] verseWords = verse.Split(" ");

        foreach (string word in verseWords){
            Word newWord = new Word(word);
            _words.Add(newWord);
        }

        _wordsRemainging = _words.Count();

        if (verseEnd == -1){
            _scriptureReference = new Reference(book,chapter,verseStart);
        }
        else {
            _scriptureReference = new Reference(book,chapter,verseStart, verseEnd);
        }

    }
    

    public void HideWord()
    {
        Boolean uniqueRandom = false;
        int wordIndex = -1;

        if (_wordsRemainging > 0)
        {
            while (!uniqueRandom)
            {
                wordIndex = _randomIndex.Next(0, _words.Count());
                if (!_words[wordIndex].IsHidden())
                {
                    uniqueRandom = true;
                }
            } 

            _words[wordIndex].setHidden();
            _wordsRemainging -= 1;
        }
    }

    public string getVerse()
    {
        string scriptureVerse = "";

        foreach (Word word in _words)
        {
           scriptureVerse = ($"{scriptureVerse} {word.getWord()}");
        }

        return scriptureVerse.Trim();
    }


    public string getReference()
    {
        return _scriptureReference.getReference();
    }

    public int getWordsRemaining()
    {
        return _wordsRemainging;
    }

}