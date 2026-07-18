class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity("03 Nov 2022", 30, 3);
        BikingActivity bikingActivity = new BikingActivity("25 July 2026", 45, 25);
        SwimmingActivity swimmingActivity = new SwimmingActivity("01 Aug 2026", 60, 20);

        // Console.WriteLine(runningActivity.GetSummary());
        // Console.WriteLine(bikingActivity.GetSummary());
        Console.WriteLine(swimmingActivity.GetSummary());
    }
}