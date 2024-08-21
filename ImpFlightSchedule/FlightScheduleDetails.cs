using AirlinesSystem.IFlightSchedule;
using AirlinesSystem.Model;

namespace AirlinesSystem.ImpFlightSchedule
{
    public class FlightScheduleDetails: IFlightScheduleDetails
    {
        private readonly List<Flight> _flights;
        private const int MaxBoxPerFlight = 20;
        public FlightScheduleDetails()
        {
            _flights = new List<Flight>();
        }
        public void LoadFlights()
        {
            // Day 1 flights
            _flights.Add(new Flight(1, "YUL", "YYZ", 1));
            _flights.Add(new Flight(2, "YUL", "YYC", 1));
            _flights.Add(new Flight(3, "YUL", "YVR", 1));

            // Day 2 flights
            _flights.Add(new Flight(4, "YUL", "YYZ", 2));
            _flights.Add(new Flight(5, "YUL", "YYC", 2));
            _flights.Add(new Flight(6, "YUL", "YVR", 2));
        }

        public void DisplaySchedule()
        {
            Console.WriteLine("Loaded Flight Schedule:");

            foreach (var flight in _flights)
            {                
                Console.WriteLine($"Flight: {flight.FlightNumber}, departure: {flight.DepartureCity}, arrival: {flight.ArrivalCity}, day: {flight.Day}");
            }
        }

        public void ScheduleOrders(List<Order> orders)
        {
            var groupedOrders = orders.GroupBy(o => o.Destination).ToDictionary(g => g.Key, g => g.ToList());
            foreach (var flight in _flights)
            {
                if (groupedOrders.ContainsKey(flight.ArrivalCity))
                {
                    var destinationOrders = groupedOrders[flight.ArrivalCity];
                    int ordersToLoad = Math.Min(destinationOrders.Count, MaxBoxPerFlight);

                    Console.WriteLine("Order scheduled for Flight: " + flight.FlightNumber);
                    for (int i = 0; i < ordersToLoad; i++)
                    {
                        Console.WriteLine($"order: {destinationOrders[i].OrderId}, flightNumber: {flight.FlightNumber}, departure: {flight.DepartureCity}, arrival: {flight.ArrivalCity}, day: {flight.Day}");
                    }

                    destinationOrders.RemoveRange(0, ordersToLoad);
                    if (destinationOrders.Count == 0)
                    {
                        groupedOrders.Remove(flight.ArrivalCity);
                    }
                }
            }
        }
    }
}
