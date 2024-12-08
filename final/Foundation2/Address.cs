public class Address{
    private string _street { get; set; }
    private string _city { get; set; }
    private string _stateProvince { get; set; }
    private string _country { get; set; }
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string ReturnAddress()
    {
        return $"{_street} {_city} {_stateProvince} {_country}";
    }

    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}