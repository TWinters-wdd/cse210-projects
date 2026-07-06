using System;

class Program
{
    static void Main(string[] args)
    {
        Product testProduct = new Product("Swiss Cheese", 1001, 1.25,3);
        Console.WriteLine(testProduct.CalculateTotalCost());

        Address testAddress = new Address("234 N 83rd Avenue", "Lansing", "Michigan", "USA");
        Console.WriteLine(testAddress.GetAddressString());

        Customer testCustomer = new Customer("John Doe", testAddress);
        Console.WriteLine(testCustomer.GetCustomerString());
    }
}