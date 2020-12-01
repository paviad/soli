namespace FlightsCompany.Interfaces
{
    public interface IAircraft
    {
        int TotalSeats { get; set; }
        int AvailableSeats { get; set; }
    }
}