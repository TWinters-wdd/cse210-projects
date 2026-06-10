public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");

        _duration = int.Parse(Console.ReadLine());
    }

    public void RunCountDown(string message, int duration)
    {
        Console.Write($"{message}: ");
        while (duration >= 0)
        {
            Console.Write($"{duration--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }

    public void DisplayEndMessage(string activityName, int activityTime)
    {
        
    }
}