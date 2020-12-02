using FlightsCompany.Interfaces;
using System;

namespace FlightsCompany.DAL {
    public class Repository : IRepository {
        public object BeginTransaction() {
            return new object();
        }

        public void Commit(object transaction) { }

        public void AddPassengerToFlight(IPassenger passanger, IFlight flight) { }

        public void AddBaggageToFlight(IBaggage passanger, IFlight flight) { }

        public IFlight GetFlight(int v) {
            throw new NotImplementedException();
        }

        public IPassenger GetPassenger(in int passengerId) {
            throw new NotImplementedException();
        }
    }
}
