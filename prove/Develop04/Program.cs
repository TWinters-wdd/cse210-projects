using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("This activity will help you relax by walking through your breathing. Clear your mind and focus on your breathing.");
        breathingActivity.RunActivity();
    }
}