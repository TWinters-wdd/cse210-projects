using System.Collections.Generic;
using System.IO;
class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private int _totalScore;

    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your goals: ");
        foreach (BaseGoal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal)+1}. {goal.GetDisplayString()}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter file name to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalScore);

            foreach (BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileString());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Load goals from which file: ");
        string inFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(inFile);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split('#');

            switch (parts[0])
            {
                case "SimpleGoal":
                    SimpleGoal newSimpleGoal = new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),parts[0],bool.Parse(parts[4]));
                    _goals.Add(newSimpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal newEternalGoal = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]),parts[0],int.Parse(parts[4]));
                    _goals.Add(newEternalGoal);
                    break;
                case "ChecklistGoal":
                    CheckListGoal newChecklistGoal = new CheckListGoal(parts[1],parts[2],int.Parse(parts[3]),parts[0],int.Parse(parts[6]),int.Parse(parts[5]),int.Parse(parts[4]));
                    _goals.Add(newChecklistGoal);
                    break;
            }
        }
    }
}