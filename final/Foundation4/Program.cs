class Program
{
    static void Main(string[] args)
    {
        Activity testActivity = new Activity("02/14/2026", 30);

        Console.WriteLine(testActivity.GetSummary());
    }
}