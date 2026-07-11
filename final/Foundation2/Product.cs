public class Product
{
    private string _name;
    private int _id;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, int id, double pricePerUnit, int quantity)
    {
        _name = name;
        _id = id;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProductLabel()
    {
        return $"Product Name: {_name} - ID: {_id}";
    }
}