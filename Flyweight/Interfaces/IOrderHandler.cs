namespace ECommerceMVP;

public interface IOrderHandler
{
    void Handle(Order order);
    void SetNext(IOrderHandler handler);
}