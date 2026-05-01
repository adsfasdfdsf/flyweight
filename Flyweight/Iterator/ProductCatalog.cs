using System.Collections;

namespace ECommerceMVP;

public class ProductCatalog: IEnumerable<Iterator.Product>
{
    private List<Iterator.Product> _products = new();
    private int _lower_bound;

    public ProductCatalog(int lowerBound = 0)
    {
        _lower_bound = lowerBound;
    }
    
    public void AddProduct(Iterator.Product product)
    {
        _products.Add(product);
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<Iterator.Product> GetEnumerator()
    {
        return new ProductIterator(_products, _lower_bound);
    }
}