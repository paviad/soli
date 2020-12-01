using System;
using System.Collections.Generic;
using System.Text;
using FlightsCompany.Interfaces;

namespace FlightsCompany.Modules
{
    public class Factory
    {
        public static IPassenger CreatePassenger() => new Passenger();
        public static IBaggage CreateBaggage() => new Baggage();
        public static IFlight CreateFlight() => new Flight();
    }
}
