abstract class Delivery
{
    public string Address { get; set; }
}

class HomeDelivery : Delivery
{
    
}

class PickPointDelivery : Delivery
{
    
}

class ShopDelivery : Delivery
{
    
}

class Order<TDelivery> where TDelivery : Delivery
{
    public TDelivery Delivery;

    private int Number;

    public Guid DelId;

    public string Description;
    public void DisplayDeliveInfo()
    {
        Console.WriteLine("DELIVERY ID : {0}\nDELIVERY DESCRIPTION : {1}\nDELIVERY ADDRESS: {2}", DelId,Description,Delivery.Address);
    }

}
class Program
{
    static void Main (string[] args)
    {
        Random rand = new Random();
        Order<HomeDelivery> order = new Order<HomeDelivery>();
        order.Delivery = new HomeDelivery();
        order.DelId = Guid.NewGuid();
        order.Description = "ROUTER 345";
        order.Delivery.Address = "st. Pushkina, h. 24 - 152";
        order.DisplayDeliveInfo();
    }
}