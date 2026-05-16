using System.IO;
using System;
class Journal
{
    List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Save to which file: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _journalEntries)
            {
                string formattedEntry = entry.CreateFileSystemString();
                outputFile.WriteLine(formattedEntry);
            }
        }
    }

    public void ReadFromFile()
    {
        Console.Write("Load from which file: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            JournalEntry fileLine = new JournalEntry();
            fileLine._date = date;
            fileLine._prompt = prompt;
            fileLine._response = response;

            _journalEntries.Add(fileLine);
        }

    }

    public void SetReminder()
    {
        Console.Write("What day should I remind you [mm/dd/yyyy]: "); // Date Format: mm/dd/yyyy
        string reminderDay = Console.ReadLine();
        Console.Write("What time should I remind you [HH:MM (AM/PM)]: ");
        string reminderTime = Console.ReadLine();

        Console.WriteLine($"Reminder set on {reminderDay} at {reminderTime}.");
    }
}