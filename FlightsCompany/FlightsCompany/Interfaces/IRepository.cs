using FlightsCompany.Interfaces;

namespace FlightsCompany.DAL {
    public interface IRepository {
        object BeginTransaction();
        void Commit(object transaction);
        void AddPassengerToFlight(IPassenger passanger, IFlight flight);
        void AddBaggageToFlight(IBaggage passanger, IFlight flight);
        IFlight GetFlight(int v);
        IPassenger GetPassenger(in int passengerId);
    }
}