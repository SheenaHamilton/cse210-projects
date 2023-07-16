using System;

public class Address
{
    private string _place;
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _postalCode;

    public Address(string place, string street, string city, string state, string country, string postal)
    {
        _place = place;
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _postalCode = postal;
    }

    public string GetPlace()
    {
        return _place;
    }

    public string GetFormattedAddress()
    {
        return $"{_place}\n{_street}\n{_city}, {_state}\n{_country}  {_postalCode}";
    }

}