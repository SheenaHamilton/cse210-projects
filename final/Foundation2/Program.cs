using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order order1 = new Order();
        order1.AddCustomer("Amy Dickenson", "4536 Park Avenue", "Govetown", "MB", "CANADA", "T0A 0T0");
        orders.Add(order1);

        Order order2 = new Order();
        order2.AddCustomer("Joshua Emery", "456 Oak Ave", "New York", "NY", "USA", "67890");
        orders.Add(order2);

        // Add products to orders
        order1.AddProduct("Laptop", 12345, 799.99, 2);
        order1.AddProduct("Smartphone", 54321, 499.99, 3);
        order1.AddProduct("Headphones", 98765, 99.95, 5);

        order2.AddProduct("Smart TV", 13579, 899.00, 1);
        order2.AddProduct("Gaming Console", 35791, 499.00, 2);
        order2.AddProduct("Fitness Tracker", 24680, 59.99, 4);

        Console.Clear();

        foreach(Order ord in orders)
        {
            Console.WriteLine("\n\n------------------- Order -------------------");
            Console.WriteLine($"\n-- PACKING LABEL --");
            Console.WriteLine(ord.GetPackingLabel());

            Console.WriteLine($"\n\n-- SHIPPING LABEL --\n");
            Console.WriteLine(ord.GetShippingLabel());

            Console.WriteLine($"\n\n-- TOTAL ORDER COST --");
            Console.WriteLine(ord.CalculateTotalCost().ToString("C"));
        }

    }

}