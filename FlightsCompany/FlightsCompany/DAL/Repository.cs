using FlightsCompany.Interfaces;
using System;

namespace FlightsCompany.DAL
{
    public class Repository : IRepository {
        public static object BeginTransaction() {
            return new object();
        }

        public static void Commit(object transaction) { }

        public static void AddPassengerToFlight(IPassenger passanger, IFlight flight) { }

        public static void AddBaggageToFlight(IBaggage passanger, IFlight flight) { }

        public static IFlight GetFlight(int v)
        {
            throw new NotImplementedException();
        }
    }
}
