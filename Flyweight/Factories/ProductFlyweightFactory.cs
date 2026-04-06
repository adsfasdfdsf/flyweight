namespace ECommerceMVP;

public class ProductFlyweightFactory
{

    private static Dictionary<string, ProductFlyweight> _flyweights = new();
    private static int _requestCount = 0;

    public static ProductFlyweight GetFlyweight(string brand, string description, string icon)
    {
        string key = $"{brand}_{description}_{icon}";
        ++_requestCount;
        if (!_flyweights.ContainsKey(key))
        {
            _flyweights[key] = new ProductFlyweight(brand, description, icon);
        }
        return _flyweights[key];
    }

    public static int GetFlyweightCount() => _flyweights.Count;

    public static void PrintStatistics() => Console.WriteLine($"RequestCount: {_requestCount}, Unique objects Created: {_flyweights.Count}");
}