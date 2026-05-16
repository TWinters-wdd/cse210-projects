using System;

class Program
{
    static void Main(string[] args)
    {

        int userChoice;

        Journal userJournal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Set a Reminder");
            Console.WriteLine("6. Quit");
            Console.Write("[1 - 6]: ");

            userChoice = int.Parse(Console.ReadLine());



            if (userChoice == 1)
            {
                JournalEntry userEntry = new JournalEntry();
                userEntry.CreateJournalEntry();
                userJournal.AddJournalEntry(userEntry);

            }
            else if (userChoice == 2)
            {
                userJournal.DisplayJournal();
            }
            else if (userChoice == 3)
            {
                userJournal.ReadFromFile();
            }
            else if (userChoice == 4)
            {
                userJournal.SaveToFile();
            }
            else if (userChoice == 5)
            {
                userJournal.SetReminder();
            }
        } while (userChoice != 6);


        // JournalEntry myJournalEntry = new JournalEntry();
        // myJournalEntry.CreateJournalEntry();
        // // myJournalEntry.DisplayJournalEntry();
        // // Console.WriteLine(myJournalEntry.CreateFileSystemString());
        // JournalEntry myJournalEntry2 = new JournalEntry();
        // myJournalEntry2.CreateJournalEntry();

        // Journal myJournal = new Journal();
        // myJournal.AddJournalEntry(myJournalEntry);
        // myJournal.AddJournalEntry(myJournalEntry2);

        // myJournal.DisplayJournal();
    }
}