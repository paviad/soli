using System;
using FlightsCompany.Interfaces;
using FlightsCompany.Modules;
using FlightsCompany.Results;

namespace FlightsCompany
{
    public class Registration
    {
        public static RegistrationResult Register(IPassenger passenger, IBaggage baggage, IFlight flight)
        {
            return new RegistrationResult();
        }
    }
}
