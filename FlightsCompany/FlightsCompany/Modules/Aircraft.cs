using FlightsCompany.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightsCompany.Modules
{
    public class Aircraft : IAircraft
    {
        public int PassengerLimit { get; private set; }
        public decimal BaggageWeightLimit { get; private set; }
        public decimal PersonalBaggageWeightLimit { get; private set; }
        public decimal PersonalBaggageNumberOfBagsLimit { get; private set; }
    }
}
