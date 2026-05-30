using System;

class Program
{
    static void Main(string[] args)
    {

        // 1. Console Displays the entire Scripture
        // 2. User hits enter, and it hides 3 random words
        // 3. User hits enter until there is no words left
        // 4. If enter is hit when all the words are hidden, The program quits (or if 'quit' is typed in)

        ScriptureReference almaVerse = new ScriptureReference("Alma", 7, 12);
        Scripture almaScripture = new Scripture(almaVerse, "And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.");
        

        // While loop that runs until all the words in the verse are IsHidden()

        string userResponse = "";
        bool allWordsHidden = false;
        while (!allWordsHidden && userResponse != "quit")
        {
            Console.Clear();
            almaScripture.DisplayScripture();
            userResponse = Console.ReadLine();
            allWordsHidden = almaScripture.HideRandomWords();
        }

        Console.Clear();
        almaScripture.DisplayScripture();
    }
}