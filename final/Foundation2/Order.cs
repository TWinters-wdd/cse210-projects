using System.ComponentModel.Design.Serialization;

public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer = new Customer();
    private int _shippingCost;
    private double _totalCost;

    public Order()
    {
    }

    public void DisplayPackingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine(p.GetProductLabel());
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.GetCustomerString());
    }

    public void SetShippingCost()
    {
        if (_customer.IsInUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void DisplayOrder()
    {
        Console.WriteLine("Customer:");
        DisplayShippingLabel();
        Console.WriteLine("\nProducts: ");
        DisplayPackingLabel();
        Console.WriteLine();
        Console.WriteLine($"Shipping Cost: ${_shippingCost.ToString("F2")}\nTotal Cost: ${GetTotalCost().ToString("F2")}");
    }

    public double GetTotalCost()
    {
        foreach (Product p in _products)
        {
            _totalCost += p.CalculateTotalCost();
        }
        return _totalCost + _shippingCost;
    }
}