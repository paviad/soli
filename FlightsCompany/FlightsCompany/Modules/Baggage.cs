using FlightsCompany.Interfaces;

namespace FlightsCompany.Modules
{
    public class Baggage : IBaggage
    {
        public int NumberOfBags { get; private set; }
        public decimal Weight { get; private set; }

        public void Add(IBaggage baggage) {
            NumberOfBags += baggage.NumberOfBags;
            Weight += baggage.Weight;
        }
    }
}
