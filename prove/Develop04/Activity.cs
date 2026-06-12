public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");

        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        RunSpinner(5);
        Console.WriteLine("");
    }

    public void RunCountDown(string message, int duration)
    {
        Console.Write($"{message}: ");
        while (duration > 0)
        {
            Console.Write($"{duration--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine("");
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!!");
        RunSpinner(5);

        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity.");
        RunSpinner(5);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void RunSpinner(int spinnerTime)
    {
        string animationString = "-\\|/";
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(spinnerTime);

        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(500);
            Console.Write("\b");
        }
    }
}