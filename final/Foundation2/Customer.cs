public class Customer
{
    private string _name;
    private Address _address = new Address();

    public Customer()
    {}

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetCustomerString()
    {
        return $"{_name}\nAddress: {_address.GetAddressString()}";
    }
}