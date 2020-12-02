namespace FlightsCompany.Interfaces
{
    public interface IFlight
    {
        IAircraft Aircraft { get; }
        bool HasPassengers { get; }
        bool IsFull { get; }
        int NumberOfPassengers { get; }
        IBaggage Baggage { get; }

        void AddPassenger(IPassenger passenger);
    }
}