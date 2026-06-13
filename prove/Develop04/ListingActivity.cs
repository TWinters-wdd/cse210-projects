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
        List<String> answers = new List<String>();
        string saveFile = "listening.txt";

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string currentItem = Console.ReadLine();
            answers.Add(currentItem);
            itemsListed++;
        }

        Console.WriteLine($"You listed {itemsListed} items!");
        Console.Write("Do you want to save your list? [yes/no] ");
        string userChoiceSave = Console.ReadLine();

        if (userChoiceSave == "yes")
        {
            SaveToFile(answers, saveFile);
            Console.WriteLine($"Answers saved to {saveFile}.");
        }

        EndActivity();
    }

    public string GetRandomPrompt(List<String> stringList)
    {
        Random random = new Random();
        int randomInt = random.Next(stringList.Count());

        return stringList[randomInt];
    }

    private void SaveToFile(List<String> infoToBeWritten, string saveFile)
    {
        foreach (string i in infoToBeWritten)
        {
            File.AppendAllText(saveFile, $"{i}\n");
        }
    }
}