class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;
    public EternalGoal() : base()
    {
        _goalType = "EternalGoal";
        _numberOfCompletions = 0;
    }

    EternalGoal(string name, string description, int points, bool status, string goalType, int completions) : base(name, description, points, status, goalType)
    {
        _numberOfCompletions = completions;
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }

    public override void RecordEvent()
    {
        MarkComplete();
        _numberOfCompletions++;
    }

    public override string GetDisplayString()
    {
        return $"[{_numberOfCompletions}] Name: {_name}, Description: {_description}, Point Value: {_numberOfPoints}";
    }
}