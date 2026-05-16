class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;
    Random _randomInt;
    int _chosenPrompt;

    // Finish this code - need more prompts
    string[] _prompts =
    {
        "How are you feeling today",
        "What challenges did you face today",
        "What was the best part of your day",
        "Who did you serve today",
        "What was the worst part of your day and why",
        "What did you study in the scriptures today",
        "Who did you talk with today"
    };

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();
        _randomInt = new Random();
        _chosenPrompt = _randomInt.Next(1, _prompts.Count());

        // Finish this code - need a random prompt
        _prompt = _prompts[_chosenPrompt];
        Console.WriteLine($"{_prompts[_chosenPrompt]}?");
        _response = Console.ReadLine();
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_response}");
    }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}