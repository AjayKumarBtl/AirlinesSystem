namespace AirlinesSystem.Model
{
    public class Order
    {
        public string OrderId { get; set; }
        public string Destination { get; set; }

        public Order(string orderId, string destination)
        {
            OrderId = orderId;
            Destination = destination;
        }
    }
}
