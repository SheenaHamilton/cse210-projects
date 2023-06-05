using System;

class Assignment
{

    string _studentName = "";
    string _topic = "";

    public Assignment(string name, string topic)
    {
         _studentName = name;
         _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public void SetStudentName(string name)
    {
        _studentName = name;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetStudentName()
    {
        return _studentName ;
    }
    public string GetTopic()
    {
       return  _topic;
    }
}