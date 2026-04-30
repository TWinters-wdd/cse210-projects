using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNum = -1;

        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            userNum = int.Parse(Console.ReadLine());
            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }
        double total = 0;
        int largestNum = 0;

        // Code for sum, average, and largest number
        foreach (int number in numbers)
        {
            total += number;
            if (number > largestNum)
            {
                largestNum = number;
            }
        }

        double average = total / numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}