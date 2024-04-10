public class Video
{
    private string _name;
    private string _author;
    private int _duration;
    List<Comment> _comments = new List<Comment>();

    public Video(string name, string author, int duration)
    {
        _name = name;
        _author = author;
        _duration = duration;
    }

    public string DisplayVideoInf()
    {
        return $"Title - {_name}\nAuthor - {_author}\nDuration - {_duration}";
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComments()
    {
        foreach(Comment c in _comments)
        {
            Console.WriteLine(c.DisplayComment());
        }
    }

    public int CommentsCount()
    {
        return _comments.Count;
    }
}