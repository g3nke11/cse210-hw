public class Order
{
    private Customer _customer { get; set; }
    private List<Product> _products { get; set; }
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n {_customer.ReturnCustomer()}\n";
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product prod in _products)
        {
            label += $"{prod.Pack()}";
        }

        return label;
    }

    public double TotalPrice()
    {
        double total = 0;
        foreach (Product prod in _products)
        {
            total += prod.Price();
        }
        if (_customer.IsUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
}