public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, Address address, string type, string weather) : base(title, description, date, time, address, type)
    {
        _weather = weather;
    }

    public void DisplayOutdoorEventDetails()
    {
        base.DisplayEventStandard();
        Console.WriteLine($"\nEvent Type: {GetEventType()}");
        Console.WriteLine($"Weather Forecast: {_weather}");
    }
}