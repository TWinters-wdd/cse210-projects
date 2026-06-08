using System;

class Program
{
    static void Main(string[] args)
    {
        Activity myActivity = new Activity("Breathing Activity", "Activity Description");

        myActivity.DisplayIntroMessage();
    }
}