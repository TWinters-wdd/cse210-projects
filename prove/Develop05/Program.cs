using System;

class Program
{
    static void Main(string[] args)
    {
        // Debug Code
        // BaseGoal myGoal = new BaseGoal();
        // myGoal.SetName();
        // myGoal.SetDescription();
        // myGoal.SetNumberOfPoints();
        // Console.WriteLine(myGoal.GetDisplayString());
        // myGoal.MarkComplete();
        // Console.WriteLine(myGoal.GetDisplayString());

        SimpleGoal myGoal = new SimpleGoal();
        myGoal.CreateGoal();
        Console.WriteLine(myGoal.GetDisplayString());
        myGoal.RecordEvent();
        Console.WriteLine(myGoal.GetDisplayString());

    }
}