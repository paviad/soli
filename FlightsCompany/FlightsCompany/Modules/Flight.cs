using FlightsCompany.Interfaces;
using FlightsCompany.DAL;
using System.Collections.Generic;

namespace FlightsCompany.Modules {
    public class Flight : IFlight {
        public IAircraft Aircraft { get; private set; } = new Aircraft();
        public bool HasPassengers => Passengers.Count != 0;
        public bool IsFull => Passengers.Count == Aircraft.PassengerLimit;
        public int NumberOfPassengers => Passengers.Count;
        public IBaggage Baggage { get; private set; } = new Baggage();

        public List<IPassenger> Passengers { get; } = new List<IPassenger>();

        // Add the passenger to the flight, without checking limits
        public void AddPassenger(IPassenger passenger) {
            Passengers.Add(passenger);
            Baggage.Add(passenger.Baggage);
        }
    }
}
