public class Product
{
    private string _name;
    private string _productID;
    private double _pricePerUnit;
    private double _quantity;
    public Product(string name, string productID, double pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string Pack()
    {
        return $"{_name}: {_productID}\n";
    }

    public double Price()
    {
        return _pricePerUnit * _quantity;
    }

    public void ChangeQuantity(double newQuantity)
    {
        _quantity = newQuantity;
    }
}