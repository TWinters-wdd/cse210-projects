class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;
    public EternalGoal() : base()
    {
        _goalType = "EternalGoal";
        _numberOfCompletions = 0;
    }

    public EternalGoal(string name, string description, int points, string goalType, int completions) : base(name, description, points, goalType)
    {
        _numberOfCompletions = completions;
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }

    public override int RecordEvent()
    {
        MarkComplete();
        _numberOfCompletions++;
        return _numberOfPoints;
    }

    public override string GetDisplayString()
    {
        return $"[{_numberOfCompletions}] Name: {_name}, Description: {_description}, Point Value: {_numberOfPoints}";
    }

    public override string GetFileString()
    {
        return $"{base.GetFileString()}#{_numberOfCompletions}";
    }
}