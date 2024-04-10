using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("221346", "Toronto", "Ontario", "Canada");
        Address address2 = new Address("321532", "Washington", "Colombia", "USA");

        Customer customer1 = new Customer("Andrew", address1);
        Customer customer2 = new Customer("Anita", address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        Product product1 = new Product("Potato", 3, 2.40, 10);
        Product product2 = new Product("Cola", 17, 2.10, 2);
        Product product3 = new Product("Chicken", 12, 13.90, 2);
        Product product4 = new Product("Bread", 15, 3.12, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.Clear();

        Console.WriteLine("First order:");
        Console.WriteLine($"Total price: {order1.TotalPrice()}");
        order1.PackingLabel();
        order1.ShippingLabel();
        Console.WriteLine("\n");
        Console.WriteLine("Second order:");
        Console.WriteLine($"Total price: {order2.TotalPrice()}");
        order2.PackingLabel();
        order2.ShippingLabel();
    }
}