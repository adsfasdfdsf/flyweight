namespace ECommerceMVP.Mediator;
using ECommerceMVP.Mediator.Modules;
public class OrderMediator: IMediator
{
    private IMediatorModule _inventoryModule;
    private IMediatorModule _paymentModule;
    private IMediatorModule _shippingModule;

    public void RegisterInventoryModule(IMediatorModule inventoryModule)
    {
        _inventoryModule = inventoryModule;
    }

    public void RegisterPaymentModule(IMediatorModule paymentModule)
    {
        _paymentModule = paymentModule;
    }

    public void RegisterShippingModule(IMediatorModule shippingModule)
    {
        _shippingModule = shippingModule;
    }
    
    public void Notify(object sender, string message)
    {
        switch (sender)
        {
            case InventoryModule inventory:
                
                _paymentModule?.OnNotify(message);
                break;
            case PaymentModule payment:
                _shippingModule?.OnNotify(message);
                break;
            case ShippingModule shipping:
                Console.WriteLine(message);
                break;
        }
    }
}