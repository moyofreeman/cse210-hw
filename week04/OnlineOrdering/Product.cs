namespace OnlineOrdering;

public class Product
{
    private string _productName;
    private string _productID;
    private int _productPrice;
    private int _productQuantity;
    private int _totalProductCost;


    public Product(string productName, string productID, int productPrice, int productQuantity)
    {
        _productName = productName;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
        _productID = productID;
    }




    public int ProductCost()
    {
        _totalProductCost = _productPrice * _productQuantity;
        return _totalProductCost;
    }
}
