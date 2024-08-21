namespace AirlinesSystem.Model
{
    public class Flight
    {
        public int FlightNumber { get; private set; }
        public string DepartureCity { get; private set; }
        public string ArrivalCity { get; private set; }
        public int Day { get; private set; }

        public Flight(int flightNumber, string departureCity, string arrivalCity, int day)
        {
            FlightNumber = flightNumber;
            DepartureCity = departureCity;
            ArrivalCity = arrivalCity;
            Day = day;
        }
    }
}
