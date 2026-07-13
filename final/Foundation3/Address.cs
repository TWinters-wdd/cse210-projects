public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _postalCode;

    public Address(string street, string city, string state, int postalCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _postalCode = postalCode;
    }

    public string GetAddressString()
    {
        return $"{_street}, {_city}, {_state}, {_postalCode}";
    }
}