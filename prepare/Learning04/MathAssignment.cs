using System;

class MathAssignment:Assignment
{

    string _textbookSection = "";
    string _problems = "";

    public MathAssignment(string studentname, string topic, string textbookSection, string problems):base(studentname,topic)
    {
         _textbookSection = textbookSection;
         _problems = problems;
    }
    
    public string GetHomeworkList()
    {
        return $"{_textbookSection} Problems: {_problems}";
    }

    
}