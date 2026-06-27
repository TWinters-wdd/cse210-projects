class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Remove Goal");
        Console.WriteLine("  7. Quit");
        Console.Write("Select a choice from the menu: ");

        int userChoice = int.Parse(Console.ReadLine());
        return userChoice;
    }

    public int DisplayGoalMenu()
    {
        Console.WriteLine("Select a goal to create: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create [1-3]: ");

        int userChoice = int.Parse(Console.ReadLine());
        return userChoice;
    }
}