 public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _postalCode;

    public Address(string street, string city, string state, string country, string postal)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _postalCode = postal;
    }

    public Boolean IsUSA()
    {
        if (_country == "USA")  return true;
        else return false;
    }

    public string GetFormattedAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}  {_postalCode}";
    }

}