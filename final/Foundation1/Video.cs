public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string comment)
    {
        Comment commentNew = new Comment(name, comment);
        _comments.Add(commentNew);
    }

    public int NumberComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"\n\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Video ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" );
        Console.WriteLine($"Title: {_title} Author: {_author} Length: {_length}");

        Console.WriteLine($"\nTotal Comments: {NumberComments()}");
        _comments.ForEach( comment => { comment.DisplayComment();});

    }

}