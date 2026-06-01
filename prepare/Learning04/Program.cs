using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment testAssignment = new Assignment("Samuel Bennet", "Multiplication");

        Console.WriteLine(testAssignment.GetSummary());

        MathAssignment testMathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");

        Console.WriteLine(testMathAssignment.GetSummary());
        Console.WriteLine(testMathAssignment.GetHomeworkList());
    }
}