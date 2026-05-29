using System;

class Program
{
    static void Main(string[] args)
    {

        // 1. Console Displays the entire Scripture
        // 2. User hits enter, and it hides 3 random words
        // 3. User hits enter until there is no words left
        // 4. If enter is hit when all the words are hidden, The program quits (or if 'quit' is typed in)
        Word myWord = new Word("Hello");
        Console.WriteLine(myWord.GetWordString());

        myWord.Hide();
        Console.WriteLine(myWord.GetWordString());

        myWord.DisplayWord();
        if (myWord.IsHidden())
        {
            Console.WriteLine(myWord.GetWordString());
        }

        ScriptureReference defaultReference = new ScriptureReference();
        ScriptureReference almaVerse = new ScriptureReference("Alma", 7, 12);
        Scripture almaScripture = new Scripture(almaVerse, "Testing with different, Stuff; sldkjfks.");
 

        Console.WriteLine(defaultReference.GetScriptureReference());
        Console.WriteLine(almaVerse.GetScriptureReference());
        almaScripture.DisplayScripture();

    }
}