namespace ECommerceMVP;

// Заказ
public class Order
{
    private List<Product> _products = new List<Product>();
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal GetTotalAmount()
    {
        return _products.Sum(p => p.Price);
    }
    public IEnumerable<Product> Products => _products;
}