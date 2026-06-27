abstract class BaseGoal
{
    protected string _name;
    protected string _description;
    protected int _numberOfPoints;
    protected bool _status;
    protected string _goalType;

    public BaseGoal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }

    public BaseGoal(string name, string description, int points, string goalType)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _goalType = goalType;
    }

    protected void SetName()
    {
        Console.Write("Enter the name of your goal: ");
        _name = Console.ReadLine();
    }

    protected void SetDescription()
    {
        Console.Write($"Enter the description for {_name} goal: ");
        _description = Console.ReadLine();
    }

    protected void SetNumberOfPoints()
    {
        Console.Write($"Enter the points earned for {_name} goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public virtual string GetDisplayString()
    {
        char statusMarker = ' ';
        if (_status)
        {
            statusMarker = 'X';
        }
        return $"[{statusMarker}] Name: {_name}, Description: {_description}, Point Value: {_numberOfPoints}";
    }

    public virtual string GetFileString()
    {
        return $"{_goalType}#{_name}#{_description}#{_numberOfPoints}";
    }

    protected void MarkComplete()
    {
        _status = true;
    }

    public abstract void CreateGoal();
    public abstract int RecordEvent();
}