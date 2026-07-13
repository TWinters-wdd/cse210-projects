public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayEventStandard()
    {
        Console.WriteLine($"Event Name: {_title}");
        Console.WriteLine($"\nDescription: {_description}");
        Console.WriteLine($"\nDate: {_date}");
        Console.WriteLine($"\nTime: {_time}");
        Console.WriteLine($"\nAddress: {_address.GetAddressString()}");
    }
}