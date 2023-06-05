using System;

class WritingAssignment:Assignment
{

    string _title = "";

    public WritingAssignment(string studentname, string topic, string title):base(studentname,topic)
    {
         _title = title;
    }
    
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

    
}