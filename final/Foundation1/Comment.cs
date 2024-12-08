public class Comment{
    private string _author;
    private string _content;
    public Comment(string author, string content)
    {
        _author = author;
        _content = content;
    }

    public void Display()
    {
        Console.WriteLine(_content);
        Console.WriteLine($"By {_author}\n");
    }
}