public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = type;
    }

    public void DisplayEventStandard()
    {
        Console.WriteLine($"Event Name: {_title}");
        Console.WriteLine($"\nDescription: {_description}");
        Console.WriteLine($"\nDate: {_date}");
        Console.WriteLine($"\nTime: {_time}");
        Console.WriteLine($"\nAddress: {_address.GetAddressString()}");
    }

    public void DisplayEventShort()
    {
        Console.WriteLine($"Event type: {_eventType}\nTitle: {_title}\nDate: {_date}");
    }

    public string GetEventType()
    {
        return _eventType;
    }
}