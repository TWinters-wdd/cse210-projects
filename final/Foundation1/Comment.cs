public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetComment(string comment)
    {
        _comment = comment;
    }

    public string GetCommentString()
    {
        return $"{_name}: {_comment}";
    }

    public void DisplayComment()
    {
        Console.WriteLine(GetCommentString());
    }
}