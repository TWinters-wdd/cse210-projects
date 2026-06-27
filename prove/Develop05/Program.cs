using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu();
        int userChoice;

        Goals goalList = new Goals();

        do
        {
            userChoice = mainMenu.DisplayMenu();
            switch (userChoice)
            {
                case 1:
                    int goalChoice = mainMenu.DisplayGoalMenu();
                    switch (goalChoice)
                    {
                        case 1:
                            SimpleGoal newSimpleGoal = new SimpleGoal();
                            newSimpleGoal.CreateGoal();
                            goalList.AddGoal(newSimpleGoal);
                            break;
                        case 2:
                            EternalGoal newEternalGoal = new EternalGoal();
                            newEternalGoal.CreateGoal();
                            goalList.AddGoal(newEternalGoal);
                            break;
                        case 3:
                            CheckListGoal newChecklistGoal = new CheckListGoal();
                            newChecklistGoal.CreateGoal();
                            goalList.AddGoal(newChecklistGoal);
                            break;
                    }
                    break;
                case 2:
                    goalList.DisplayGoals();
                    break;
                case 3:
                    goalList.SaveGoals();
                    break;
                case 4:
                    goalList.LoadGoals();
                    break;
            }
        }
        while (userChoice != 6);

        // Debug Code
        // BaseGoal myGoal = new BaseGoal();
        // myGoal.SetName();
        // myGoal.SetDescription();
        // myGoal.SetNumberOfPoints();
        // Console.WriteLine(myGoal.GetDisplayString());
        // myGoal.MarkComplete();
        // Console.WriteLine(myGoal.GetDisplayString());

        // SimpleGoal myGoal = new SimpleGoal();
        // myGoal.CreateGoal();
        // Console.WriteLine(myGoal.GetDisplayString());
        // myGoal.RecordEvent();
        // Console.WriteLine(myGoal.GetDisplayString());

        // EternalGoal myEternalGoal = new EternalGoal();
        // myEternalGoal.CreateGoal();
        // Console.WriteLine(myEternalGoal.GetDisplayString());
        // myEternalGoal.RecordEvent();
        // Console.WriteLine(myEternalGoal.GetDisplayString());

    }
}