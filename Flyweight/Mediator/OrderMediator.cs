namespace ECommerceMVP.Mediator;
using ECommerceMVP.Mediator.Modules;
public class OrderMediator: IMediator
{
    private InventoryModule _inventoryModule;
    private PaymentModule _paymentModule;
    private ShippingModule _shippingModule;

    public void RegisterInventoryModule(InventoryModule inventoryModule)
    {
        _inventoryModule = inventoryModule;
    }

    public void RegisterPaymentModule(PaymentModule paymentModule)
    {
        _paymentModule = paymentModule;
    }

    public void RegisterShippingModule(ShippingModule shippingModule)
    {
        _shippingModule = shippingModule;
    }
    
    public void Notify(object sender, string message)
    {
        switch (sender)
        {
            case InventoryModule inventory:
                
                _paymentModule?.ValidatePayment(message);
                break;
            case PaymentModule payment:
                _shippingModule?.ScheduleShipping(message);
                break;
            case ShippingModule shipping:
                Console.WriteLine(message);
                break;
        }
    }
}