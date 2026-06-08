public class Activity
{
    private string _name;
    private string _description;
    // private int _countdownTime;
    // private int _spinnerTime;
    private int _activityDuration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayIntroMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");

        int userTime = int.Parse(Console.ReadLine());
        SetDurationTime(userTime);
    }

    public void DisplayEndMessage(string activityName, int activityTime)
    {
        
    }

    public void SetDurationTime(int durationTime)
    {
        _activityDuration = durationTime;
    }
}