using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment testAssignment = new Assignment("Samuel Bennet", "Multiplication");

        Console.WriteLine(testAssignment.GetSummary());
    }
}