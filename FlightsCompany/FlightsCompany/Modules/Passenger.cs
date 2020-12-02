using FlightsCompany.Interfaces;

namespace FlightsCompany.Modules
{
    public class Passenger : IPassenger
    {
        public IBaggage Baggage { get; private set; } = new Baggage();
    }
}