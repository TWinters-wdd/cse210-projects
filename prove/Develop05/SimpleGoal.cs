class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base()
    {
        _goalType = "SimpleGoal";
    }

    public SimpleGoal(string name, string description, int points, string goalType, bool status) : base(name, description, points, goalType)
    {
        _goalType = "SimpleGoal";
        _status = status;
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
    }

    public override string GetFileString()
    {
        return $"{base.GetFileString()}#{_status}";
    }
}