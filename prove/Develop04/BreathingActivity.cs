
class BreathingActivity : Activity
{
    public BreathingActivity(string description) : base("Breathing", description)
    {
    }

    public void RunActivity()
    {
        StartActivity();
        RunCountDown("Breathe In", 4);
        RunCountDown("Breathe Out", 6);
    }
}