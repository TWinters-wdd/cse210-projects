using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{

    private List<String> _prompts = new List<String> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<String> _reflectQuestions = new List<String> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

    public ReflectionActivity(string description) : base("Reflection", description)
    {  
    }

    public string GetRandomItem(List<String> stringList)
    {
        Random random = new Random();
        int randomInt = random.Next(stringList.Count());

        return stringList[randomInt];
    }

    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"\n--- {GetRandomItem(_prompts)} ---");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        RunCountDown("You may begin in", 5);
        Console.Clear();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write($"{GetRandomItem(_reflectQuestions)} ");
            RunSpinner(10);
            Console.WriteLine("");
        }

        EndActivity();
    }
}