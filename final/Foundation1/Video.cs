public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public string GetVideoString()
    {
        return $"Title: {_title}\nVideo by: {_author}\nVideo Length: {_length} (seconds)\nTotal Comments: {_comments.Count()}";
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public void AddComment(Comment vidComment)
    {
        _comments.Add(vidComment);
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetCommentString());
        }
    }
}