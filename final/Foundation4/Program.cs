class Program
{
    static void Main(string[] args)
    {
        List<Activity> exercises = new List<Activity>();

        RunningActivity runningActivity = new RunningActivity("03 Nov 2022", 30, 3);
        BikingActivity bikingActivity = new BikingActivity("25 July 2026", 45, 25);
        SwimmingActivity swimmingActivity = new SwimmingActivity("01 Aug 2026", 60, 20);

        exercises.Add(runningActivity);
        exercises.Add(bikingActivity);
        exercises.Add(swimmingActivity);

        foreach (Activity exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
            Console.WriteLine();
        }
    }
}