public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

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
        Console.WriteLine($"\n\nVideo -------------------------------------" );
        Console.WriteLine($"Title: {_title} \nAuthor: {_author} \nLength: {_length} min");

        Console.WriteLine($"Total Comments: {NumberComments()}");
        Console.WriteLine($"\n- Comments -");
        _comments.ForEach( comment => { comment.DisplayComment();});

    }

}