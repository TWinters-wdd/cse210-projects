using System;

class Program
{
    static void Main(string[] args)
    {
        Product testProduct = new Product("Swiss Cheese", 1001, 1.25,3);
        Console.WriteLine(testProduct.CalculateTotalCost());
    }
}