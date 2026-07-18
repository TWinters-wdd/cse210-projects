public abstract class Activity
{
    private string _date;
    private float _duration;

    public Activity(string date, float duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} ({_duration} min)";
    }

    public string GetDate()
    {
        return _date;
    }

    public float GetDuration()
    {
        return _duration;
    }
}