public class Customer
{
    private string _name { get; set; }
    private Address _address { get; set; }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string ReturnCustomer()
    {
        return $"{_name}: {_address.ReturnAddress()}";
    }

    public bool IsUSA()
    {
        return _address.IsUSA();
    }
}