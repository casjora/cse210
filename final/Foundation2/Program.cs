using System;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        var customer1 = new Customer("John Doe", address1);

        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 19.99m, 2));

        Console.WriteLine($"Order 1 Total Cost: ${order1.CalculateTotalCost()}\n");


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        var address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        var customer2 = new Customer("Jane Smith", address2);

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P003", 599.99m, 1));
        order2.AddProduct(new Product("Headphones", "P004", 49.99m, 1));
        Console.WriteLine($"Order 2 Total Cost: ${order2.CalculateTotalCost()}\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}