using System;
using System.Collections.Generic;

class ListeningActivity : Activity
{

    List<String> _prompts = new List<String> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };

    public ListeningActivity(string description) : base("Listening", description)
    {
    }

    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt(_prompts)} ---");
        RunCountDown("You may begin in", 5);

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
        }

        EndActivity();
    }

    public string GetRandomPrompt(List<String> stringList)
    {
        Random random = new Random();
        int randomInt = random.Next(stringList.Count());

        return stringList[randomInt];
    }
}