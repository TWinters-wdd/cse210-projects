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
            goalList.DisplayScore();
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
                case 5:
                    goalList.DisplayGoals();
                    Console.Write("Which goal did you complete: ");
                    int completedGoal = int.Parse(Console.ReadLine()) - 1;

                    int addPoints = goalList.GetGoals()[completedGoal].RecordEvent();
                    goalList.AddPoints(addPoints);

                    break;
                case 6:
                    goalList.DisplayGoals();
                    Console.Write("Which goal do you want to delete: ");
                    int deletedGoal = int.Parse(Console.ReadLine()) - 1;

                    goalList.GetGoals().RemoveAt(deletedGoal);
                    break;
            }
        }
        while (userChoice != 7);
    }
}