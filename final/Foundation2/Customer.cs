 public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name)
    {
        _name = name;
    }
    public void AddCustomerAddress(string street, string city, string state, string country, string postal)
    {
        _address = new Address(street,city,state,country,postal);
    }

    public Boolean IsUSACustomer()
    {
        return _address.IsUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetFormattedAddress();
    }

}