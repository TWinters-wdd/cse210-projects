public class BikingActivity : Activity
{
    private float _speed;

    public BikingActivity(string date, float duration, float speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return GetDuration() / 60 * GetSpeed();
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}