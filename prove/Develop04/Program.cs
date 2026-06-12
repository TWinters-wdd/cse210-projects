using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("This activity will help you relax by walking through your breathing. Clear your mind and focus on your breathing.");

        ReflectionActivity reflectionActivity = new ReflectionActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        ListingActivity listingActivity = new ListingActivity("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain time.");

        int userChoice;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    breathingActivity.RunActivity();
                    break;
                case 2:
                    Console.Clear();
                    reflectionActivity.RunActivity();
                    break;
                case 3:
                    Console.Clear();
                    listingActivity.RunActivity();
                    break;
                case 4:
                    break;
            }
        } while (userChoice != 4);

    }
}