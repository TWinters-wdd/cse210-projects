
class BreathingActivity : Activity
{
    public BreathingActivity(string description) : base("Breathing", description)
    {
    }

    public void RunActivity()
    {
        StartActivity();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            RunCountDown("\nBreathe In: ", 4);
            RunCountDown("Breathe Out: ", 6);            
        }

        EndActivity();
    }
}