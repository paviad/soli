using System;
using FlightsCompany.Exceptions;
using FlightsCompany.Interfaces;
using FlightsCompany.Modules;
using FlightsCompany.Results;

namespace FlightsCompany
{
    //I am back
    public class Registration
    {
        public static void Register(IPassenger passenger, IBaggage baggage, IFlight flight)
        {
            if (flight.IsFull) {
                throw new FlightFullException();
            }

            var flightBaggageWeightIncludingPassengerBaggage = flight.Baggage.Weight + passenger.Baggage.Weight;
            if (flightBaggageWeightIncludingPassengerBaggage > flight.Aircraft.BaggageWeightLimit) {
                throw new FlightBaggageWeightExceededException();
            }

            if (passenger.Baggage.Weight > flight.Aircraft.PersonalBaggageWeightLimit) {
                throw new PersonalBaggageWeightExceededException();
            }
            //I am here hi
            if (passenger.Baggage.NumberOfBags > flight.Aircraft.PersonalBaggageNumberOfBagsLimit) {
                throw new PersonalBaggageNumberOfBagsExceededException();
            }

            flight.AddPassenger(passenger);
        }
    }
}
