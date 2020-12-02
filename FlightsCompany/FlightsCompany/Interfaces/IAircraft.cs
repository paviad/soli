namespace FlightsCompany.Interfaces
{
    public interface IAircraft
    {
        public int PassengerLimit { get; }
        public decimal BaggageWeightLimit { get; }
        public decimal PersonalBaggageWeightLimit { get; }
        public decimal PersonalBaggageNumberOfBagsLimit { get; }
    }
}
