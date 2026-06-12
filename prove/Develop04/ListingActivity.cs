using System;
using System.Collections.Generic;

class ListingActivity : Activity
{

    List<String> _prompts = new List<String> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };

    public ListingActivity(string description) : base("Listening", description)
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
        int itemsListed = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemsListed++;
        }
        Console.WriteLine($"You listed {itemsListed} items!");
        EndActivity();
    }

    public string GetRandomPrompt(List<String> stringList)
    {
        Random random = new Random();
        int randomInt = random.Next(stringList.Count());

        return stringList[randomInt];
    }
}