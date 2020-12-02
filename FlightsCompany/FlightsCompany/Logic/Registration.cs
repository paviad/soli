using System;
using FlightsCompany.DAL;
using FlightsCompany.Exceptions;
using FlightsCompany.Interfaces;
using FlightsCompany.Modules;
using FlightsCompany.Results;

namespace FlightsCompany
{
    public class Registration : IRegistration {
        private readonly IRepository _repository;

        public Registration(IRepository repository) {
            _repository = repository;
        }

        public void Register(IPassenger passenger, IFlight flight)
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

            if (passenger.Baggage.NumberOfBags > flight.Aircraft.PersonalBaggageNumberOfBagsLimit) {
                throw new PersonalBaggageNumberOfBagsExceededException();
            }

            AddPassenger(flight, passenger);
        }

        private void AddPassenger(IFlight flight, IPassenger passenger) {
            var transaction = _repository.BeginTransaction();

            _repository.AddPassengerToFlight(passenger, flight);
            _repository.AddBaggageToFlight(passenger.Baggage, flight);

            _repository.Commit(transaction);

            flight.AddPassenger(passenger);
        }
    }
}
