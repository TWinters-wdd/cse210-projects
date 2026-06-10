using System;

class Program
{
    static void Main(string[] args)
    {
        Activity myActivity = new Activity("Breathing", "This will help you breathe.");

        myActivity.StartActivity();
        myActivity.RunCountDown("Breathe In", 10);
    }
}