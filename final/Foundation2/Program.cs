using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("234 N 83rd Avenue", "Lansing", "Michigan", "USA");

        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order();
        order1.AddProduct(new Product("Editing Software", 1002, 50.50, 1));
        order1.AddProduct(new Product("Music Software", 2010, 85.80, 1));
        order1.SetCustomer(customer1);
        order1.SetShippingCost();

        order1.DisplayOrder();
        Console.WriteLine();

        Address address2 = new Address("1234 N Example Lane", "Phoenix", "Arizona", "USA");
        Customer customer2 = new Customer("Mike John", address2);

        Order order2 = new Order();
        order2.AddProduct(new Product("Nintendo Switch", 8001, 555.10, 1));
        order2.AddProduct(new Product("Oreos", 1212, 5.00, 3));
        order2.SetCustomer(customer2);
        order2.SetShippingCost();

        order2.DisplayOrder();
        Console.WriteLine();

        Address address3 = new Address("1298 Street Avenue", "Buenos Aires", "Brazil", "Brazil");
        Customer customer3 = new Customer("Juan David", address3);

        Order order3 = new Order();
        order3.AddProduct(new Product("Bananas", 29983, 2.10, 2));
        order3.AddProduct(new Product("T-Shirt", 89983, 25, 2));
        order3.SetCustomer(customer3);
        order3.SetShippingCost();

        order3.DisplayOrder();
    }
}