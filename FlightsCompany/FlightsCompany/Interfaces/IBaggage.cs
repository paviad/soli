namespace FlightsCompany.Interfaces
{
    public interface IBaggage
    {
        int NumberOfBags { get; }
        decimal Weight { get; }

        void Add(IBaggage baggage);
    }
}