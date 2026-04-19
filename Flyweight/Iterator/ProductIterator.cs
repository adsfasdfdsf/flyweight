using System.Collections;

namespace ECommerceMVP;

public class ProductIterator: IEnumerator, IEnumerator<Iterator.Product>
{
    private readonly List<Iterator.Product> _products;
    private int _index;
    private int _lower_bound;

    public ProductIterator(List<Iterator.Product> products, int lowerBound = 0)
    {
        _products = products;
        _index = -1;
        _lower_bound = lowerBound;
    }

    public bool MoveNext()
    {
        do{
            _index++;
            if (_index >= _products.Count){
                return false;
            }
        } while (_products[_index].Price < _lower_bound);
        
        return true;
    }
    
    public void Reset()
    {
        _index = -1;
    }
    
    object IEnumerator.Current => Current;
    
    public Iterator.Product Current
    {
        get  { return _products[_index]; }
    }
    
    public void Dispose()
    {
    }
    
}