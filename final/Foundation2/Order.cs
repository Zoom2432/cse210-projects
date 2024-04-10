public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalPrice()
    {
        double totalPrice = 0;
        
        foreach (Product p in _products)
        {
            totalPrice += p.TotalPrice();
        }

        if (_customer.GetAddres().countryUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public void PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product p in _products)
        {
            Console.WriteLine($"Name: {p.GetName()}. Id: {p.GetId()}.");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine($"Shipping Label:\n{_customer.DisplayData()}");
    }
}