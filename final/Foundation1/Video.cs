public class Video {
    private string _title;
    private string _author;
    private float _length;
    private List<Comment> _comments;

    public Video(string title, string author, float length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_length} minutes\n");
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComments()
    {
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}