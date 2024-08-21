using AirlinesSystem.Model;
namespace AirlinesSystem.IFlightSchedule
{
    public interface IOrderDetails
    {
        List<Order> LoadOrders(string filePath);
    }
}
