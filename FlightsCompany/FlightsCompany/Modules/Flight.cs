using FlightsCompany.Interfaces;

namespace FlightsCompany.Modules
{
    public class Flight : IFlight
    {
        public object Aircraft { get; }

        public bool HasPassengers { get; set; };

        public void AddPassenger(Passenger passenger) {
            // TODO: manipulate HasPassengers
        }
    }
}
