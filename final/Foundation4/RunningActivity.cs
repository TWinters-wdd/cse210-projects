public class RunningActivity : Activity
{
    private float _distance;
    public RunningActivity(string date, float duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return _distance / GetDuration() * 60;
    }

    public override float GetPace()
    {
        return GetDuration() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min)- Distance {_distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}