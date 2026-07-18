public class SwimmingActivity : Activity
{
    private float _numLaps;

    public SwimmingActivity(string date, float duration, float numberOfLaps) : base(date, duration)
    {
        _numLaps = numberOfLaps;
    }

    public override float GetDistance()
    {
        return _numLaps * 50 / 1000 * (float)0.62;
    }

    public override float GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetDuration()} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}