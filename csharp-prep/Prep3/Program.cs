using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int intGuess = -1;

        while (intGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string strGuess = Console.ReadLine();
            intGuess = int.Parse(strGuess);

            if (intGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (intGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        
    }
}