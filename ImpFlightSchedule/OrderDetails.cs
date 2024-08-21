using AirlinesSystem.IFlightSchedule;
using AirlinesSystem.Model;
using Newtonsoft.Json;
namespace AirlinesSystem.ImpFlightSchedule
{
    public class OrderDetails: IOrderDetails
    {
        public List<Order> LoadOrders(string filePath)
        {
            var jsonData = File.ReadAllText(filePath);
            var ordersDict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(jsonData);

            List<Order> orders = new();

            foreach (var entry in ordersDict)
            {
                orders.Add(new Order(entry.Key, entry.Value["destination"]));
            }

            return orders;
        }
    }
}
