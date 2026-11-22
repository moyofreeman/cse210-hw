namespace OnlineOrdering;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        // 1. Create an address
        Address address1 = new Address(
            "123 Main Street", "New York", "NY", "USA");

        // 2. Create a customer
        Customer customer1 = new Customer("John Smith", address1);

        // 3. Create products
        Product laptop = new Product("Laptop", "P001", 500, 2);
        Product mouse = new Product("Mouse", "P002", 20, 3);

        // 4. Create an order
        Order order1 = new Order(customer1);

        // 5. Add products to the order
        order1.AddProduct(laptop);
        order1.AddProduct(mouse);

        
        Address address2 = new Address(
        "37473 Block 8",
        "Gaborone",
        "South-East District",
        "Botswana");

        // Create Freeman Moyo
        Customer customer2 = new Customer("Freeman Moyo", address2);

        // Create his products
        Product phone = new Product("Phone", "P003", 800, 1);
        Product charger = new Product("Charger", "P004", 25, 2);

        // Create his order
        Order order2 = new Order(customer2);

        // Add products
        order2.AddProduct(phone);
        order2.AddProduct(charger);




















        Console.WriteLine("Customer: " + customer1.GetCustomerName());

        Console.WriteLine("Product 1 cost: " + laptop.ProductCost());

        Console.WriteLine("Product 2 cost: " + mouse.ProductCost());

        Console.WriteLine("Customer lives in USA: " + customer1.ResidencyStatus());
        Console.WriteLine("Order total: $" + order1.TotalCost());


        Console.WriteLine("Customer: " + customer2.GetCustomerName());

        Console.WriteLine("Product 1 cost: " + laptop.ProductCost());

        Console.WriteLine("Product 2 cost: " + mouse.ProductCost());

        Console.WriteLine("Customer lives in USA: " + customer2.ResidencyStatus());
        Console.WriteLine("Order total: $" + order2.TotalCost());
    }

    
}