public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;
    public LectureEvent(string title, string description, string date, string time, Address address, string type, string speaker, int capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayLectureDetails()
    {
        base.DisplayEventStandard();
        Console.WriteLine($"\nEvent Type: {GetEventType()}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Max Capacity: {_capacity}");
    }
}