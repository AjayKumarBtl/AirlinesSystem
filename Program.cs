using AirlinesSystem.IFlightSchedule;
using AirlinesSystem.ImpFlightSchedule;
using AirlinesSystem.Model;

IFlightScheduleDetails flightScheduleManager = new FlightScheduleDetails();
OrderDetails orderManager = new();
flightScheduleManager.LoadFlights();

flightScheduleManager.DisplaySchedule();

string filePath = Path.Combine(@"SampleOrderData\coding-assigment-orders.json");
List<Order> orders = orderManager.LoadOrders(filePath);
flightScheduleManager.ScheduleOrders(orders);

Console.ReadLine();