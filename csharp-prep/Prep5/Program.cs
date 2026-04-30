using System;

class Program
{
    static void Main(string[] args)
    {
        int userBirthYear;
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);
        PromptUserBirthYear(out userBirthYear);
        DisplayResult(userName, numberSquared, userBirthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static void PromptUserBirthYear(out int userBirthYear)
    {
        Console.Write("Please enter the year you were born: ");
        userBirthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int numSquared = number * number;
        return numSquared;
    }

    static void DisplayResult(string userName, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{userName}, you will turn {DateTime.Now.Year - birthYear} this year.");
    }
}