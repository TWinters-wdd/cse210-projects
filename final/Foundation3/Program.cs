class Program
{
    static void Main(string[] args)
    {
        // Lecture Event + Address
        Address lectureAddress = new Address("25874 N Street Drive","Rexburg", "Idaho", 83440);
        LectureEvent lectureEvent = new LectureEvent("Motivational Speaker", "Mr. Mans is coming to speak at Blanks Park", "10/20/2026", "12:00 PM", lectureAddress, "Lecture", "Mr. Mans", 1000);

        // Reception Event + Address
        Address receptionAddress = new Address("88338 West Apples Lane", "New York City", "New York", 10074);
        ReceptionEvent receptionEvent = new ReceptionEvent("Wedding Reception", "Reception for Ash and Trev", "04/05/2025", "7:00 PM", receptionAddress, "Reception", "twin@gmail.com");

        // Lecture Event Display
        Console.WriteLine($"{lectureEvent.GetEventType()} Event Standard Display: ");
        lectureEvent.DisplayEventStandard();
        Console.WriteLine();

        Console.WriteLine($"{lectureEvent.GetEventType()} Event Full Display: ");
        lectureEvent.DisplayLectureDetails();
        Console.WriteLine();

        Console.WriteLine($"{lectureEvent.GetEventType()} Event Short Display: ");
        lectureEvent.DisplayEventShort();
        Console.WriteLine();

        // Reception Event Display
        Console.WriteLine($"{receptionEvent.GetEventType()} Event Standard Display: ");
        receptionEvent.DisplayEventStandard();
        Console.WriteLine();

        Console.WriteLine($"{lectureEvent.GetEventType()} Event Full Display: ");
        receptionEvent.DisplayReceptionDetails();
        Console.WriteLine();

        Console.WriteLine($"{receptionEvent.GetEventType()} Event Short Display: ");
        receptionEvent.DisplayEventShort();
    }
}