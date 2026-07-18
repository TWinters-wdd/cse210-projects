class Program
{
    static void Main(string[] args)
    {
        Activity testActivity = new RunningActivity("10/20/2022", 30, 3);

        Console.WriteLine(testActivity.GetSummary());
    }
}