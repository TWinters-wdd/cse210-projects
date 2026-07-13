public class ReceptionEvent : Event
{
    private string _rsvpEmail;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string type, string rsvpEmail) : base(title, description, date, time, address, type)
    {
        _rsvpEmail = rsvpEmail;
    }

    public void DisplayReceptionDetails()
    {
        base.DisplayEventStandard();
        Console.WriteLine($"\nEvent Type: {GetEventType()}");
        Console.WriteLine($"RSVP: {_rsvpEmail}");
    }
}