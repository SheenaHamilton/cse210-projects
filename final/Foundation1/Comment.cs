public class Comment
{
    private string _personName;
    private string _comment;

    public Comment(string name, string comment)
    {
        _personName = name;
        _comment = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"\nName: {_personName}");
        Console.WriteLine(_comment);
    }

}