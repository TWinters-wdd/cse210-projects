class CheckListGoal : BaseGoal
{
    protected int _numberOfCompletions;
    protected int _maxGoals;
    protected int _bonusPoints;

    public CheckListGoal() : base()
    {
        _numberOfCompletions = 0;
        _maxGoals = 0;
        _bonusPoints = 0;
        _goalType = "ChecklistGoal";
    }

    public CheckListGoal(string name, string description, int points,string goalType, int completions, int max, int bonus) : base(name, description, points, goalType)
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
    }

    protected void SetMaxGoal()
    {
        Console.Write("Enter the times you plan to complete the goal: ");
        _maxGoals = int.Parse(Console.ReadLine());
    }

    protected void SetBonusPoints()
    {
        Console.Write($"Enter the Bonus Points for completing the goal {_maxGoals} times: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
        SetMaxGoal();
        SetBonusPoints();
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        if (_numberOfCompletions < _maxGoals)
        {
            return _numberOfPoints;
        }
        else
        {
            MarkComplete();
            return _numberOfPoints + _bonusPoints;
        }
    }

    public override string GetFileString()
    {
        return $"{base.GetFileString()}#{_bonusPoints}#{_maxGoals}#{_numberOfCompletions}";
    }

    public override string GetDisplayString()
    {
        return $"{base.GetDisplayString()} -- {_numberOfCompletions} / {_maxGoals} completed";
    }
}