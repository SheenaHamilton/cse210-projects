public class Order
{
    private Customer _customer;
    private List<Product> _orderProducts = new List<Product>();

    public void AddCustomer(string name, string street, string city, string state, string country, string postal)
    {
        _customer = new Customer(name);
        _customer.AddCustomerAddress( street,  city,  state,  country,  postal);
    }

    public void AddProduct(string name, int id, double price, int quantity)
    {
        Product addProduct = new Product(name,id,price,quantity);
        _orderProducts.Add(addProduct);
    }
    public double CalculateTotalCost()
    {
        double sumtotals = 0;
        
        foreach (Product productitem in _orderProducts)
        {
            sumtotals = sumtotals + productitem.GetTotalPrice();
        }

        if (_customer.IsUSACustomer() == true) sumtotals += 5;
        else sumtotals += 35;
        
        return sumtotals;
    }

    public string GetPackingLabel()
    {
        string prodName = "PRODUCT NAME";
        string prodID =  "ID";
        string quantity = "QTY";

        string packingLabel = $"\n{prodName.PadRight(20)}{prodID.PadRight(10)}{quantity.PadLeft(10)}";
        packingLabel = packingLabel + $"\n----------------------------------------";

        foreach (Product orderProduct in _orderProducts)
        {
            prodName = orderProduct.GetName();
            prodID =  $"{orderProduct.GetID()}";
            quantity = orderProduct.GetQuantity().ToString();

            packingLabel += $"\n{prodName.PadRight(20)}{prodID.PadRight(10)}{quantity.PadLeft(10)}";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()} \n{_customer.GetAddress()}";
    }


}