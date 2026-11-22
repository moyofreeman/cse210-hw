using System.Collections.Generic;
namespace OnlineOrdering;

public class Order
{
    private List<Product> _products = new();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double ProductCost()
    {
        // should return total costs of ordered Items
        // either say productCost * quantity
        // Compute total for different products
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.ProductCost();
        }

        return total;
    }

    public double ShippingCost()
    {
        // check location
        // if location is US, then return $5
        // if location is not US, then return $35
        if (_customer.ResidencyStatus())
        {
            return 5;
        }

        return 35;
    }

    public double TotalCost()
    {
        // ProductCost + ShippingCost
        // return value
        return ProductCost() + ShippingCost();
    }
}