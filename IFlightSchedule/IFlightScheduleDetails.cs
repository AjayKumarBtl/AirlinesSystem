using AirlinesSystem.Model;

namespace AirlinesSystem.IFlightSchedule
{
    public interface IFlightScheduleDetails
    {
        void LoadFlights();
        void ScheduleOrders(List<Order> orders);
        void DisplaySchedule();
    }
}
