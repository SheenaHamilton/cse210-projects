using System;

class Word
{
    private string _word;
    private Boolean _isHidden;

    public Word(string newWord)
    {
        _word = newWord;
        _isHidden = false;
    }

    public string getWord()
    {
        string returnWord = "";

        if (_isHidden == true)
        {
            for (int i = 0; (i < _word.Length); i++)
            {
                returnWord = returnWord + "_";
            }
        }
        else
        {
            returnWord = _word;
        }
        return returnWord;
    }
    public void setHidden()
    {
        _isHidden = true;
    }
    public Boolean IsHidden()
    {
        return _isHidden;
    }
    
    
}