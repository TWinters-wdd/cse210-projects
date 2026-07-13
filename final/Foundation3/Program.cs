class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("25874 N Street Drive","Rexburg", "Idaho", 83440);
        LectureEvent lectureEvent = new LectureEvent("Motivational Speaker", "Mr. Mans is coming to speak at Blanks Park", "10/20/2026", "12:00 PM", address1, "Lecture", "Mr. Mans", 1000);

        lectureEvent.DisplayEventStandard();
        Console.WriteLine();
        lectureEvent.DisplayLectureDetails();
        Console.WriteLine();
        lectureEvent.DisplayEventShort();
    }
}