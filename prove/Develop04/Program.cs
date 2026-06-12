using System;

class Program
{
    static void Main(string[] args)
    {
        // BreathingActivity breathingActivity = new BreathingActivity("This activity will help you relax by walking through your breathing. Clear your mind and focus on your breathing.");
        // breathingActivity.RunActivity();

        // ReflectionActivity reflectionActivity = new ReflectionActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        // reflectionActivity.RunActivity();

        ListeningActivity listeningActivity = new ListeningActivity("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain time.");
        listeningActivity.RunActivity();
    }
}