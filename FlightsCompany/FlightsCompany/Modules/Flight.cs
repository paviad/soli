using FlightsCompany.Interfaces;
using FlightsCompany.DAL;
using System.Collections.Generic;

namespace FlightsCompany.Modules {
    public class Flight : IFlight {
        public IAircraft Aircraft { get; private set; } = new Aircraft();
        public bool HasPassengers => Passengers.Count != 0;
        public bool IsFull => Passengers.Count == Aircraft.PassengerLimit;
        public IBaggage Baggage { get; private set; } = new Baggage();

        public List<IPassenger> Passengers { get; } = new List<IPassenger>();

        // Add the passenger to the flight, without checking limits
        public void AddPassenger(IPassenger passenger) {
            var transaction = Repository.BeginTransaction();

            Passengers.Add(passenger);
            Repository.AddPassengerToFlight(passenger, this);

            Baggage.Add(passenger.Baggage);
            Repository.AddBaggageToFlight(passenger.Baggage, this);

            Repository.Commit(transaction);
        }
    }
}
