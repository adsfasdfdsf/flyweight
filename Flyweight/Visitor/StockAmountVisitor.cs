namespace ECommerceMVP.Visitor;

public class StockAmountVisitor: IOrderVisitor
{
    private decimal _in_stock_amount = 0;
    
    public void PrintReport()
    {
        Console.WriteLine("Stock Report - Total Amount in stock: {0}", _in_stock_amount);
    }

    public void Visit(Order order)
    {
        _in_stock_amount += Convert.ToDecimal(order.InStock);
    }
}