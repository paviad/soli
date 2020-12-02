using System;
using System.Linq.Expressions;
using FlightsCompany;
using FlightsCompany.DAL;
using FlightsCompany.Modules;
using NUnit.Framework;

namespace FlightsCompanyTests {
    public class RegistrationTests {
        private Repository _repository;

        [SetUp]
        public void Setup() {
            _repository = new Repository();
        }

        [Test]
        public void CreateFlight_FlightHasNoPassengers() {
            var f = new FlightsCompany.Modules.Flight();
            Assert.NotNull(f);

            Assert.IsFalse(f.HasPassengers);
        }

        [Test]
        public void CreatePassenger() {
            var f = new FlightsCompany.Modules.Passenger();
            Assert.NotNull(f);
        }

        [Test]
        public void CreateBaggage() {
            var f = new FlightsCompany.Modules.Baggage();
            Assert.NotNull(f);
        }

        [Test]
        public void AddPassengerToFlight() {
            var f = new FlightsCompany.Modules.Flight();
            var p = new FlightsCompany.Modules.Passenger();

            f.AddPassenger(p);
        }


        [Test]
        public void AddPassengerToFlight_FlightHasPassengers() {
            var f = new FlightsCompany.Modules.Flight();
            var p = new FlightsCompany.Modules.Passenger();

            f.AddPassenger(p);

            Assert.IsTrue(f.HasPassengers);
        }

        [Test]
        public void Register() {
            var passenger = new Passenger();
            var flight = new Flight();

            var aircraft = (FlightsCompany.Modules.Aircraft)flight.Aircraft;

            SetPrivate(aircraft, x => x.PassengerLimit, 20);
            SetPrivate(aircraft, x => x.BaggageWeightLimit, 1000);
            SetPrivate(aircraft, x => x.PersonalBaggageNumberOfBagsLimit, 300);
            SetPrivate(aircraft, x => x.PersonalBaggageWeightLimit, 150);

            var passengerBaggage = (FlightsCompany.Modules.Baggage) passenger.Baggage;

            SetPrivate(passengerBaggage, x => x.Weight, 20);
            SetPrivate(passengerBaggage, x => x.NumberOfBags, 3);

            var registration = new Registration(_repository);

            registration.Register(passenger, flight);

            Assert.IsTrue(flight.NumberOfPassengers == 1);
            Assert.IsTrue(flight.Baggage.Weight == 20);
            Assert.IsTrue(flight.Baggage.NumberOfBags == 3);
        }

        /// <summary>
        /// Helper function to set private members of tested objects.
        /// </summary>
        private void SetPrivate<T, TProp>(T obj, Expression<Func<T, TProp>> func, TProp i) {
            var t = (MemberExpression)func.Body;
            var name = t.Member.Name;
            var prop = obj.GetType().GetProperty(name);
            prop.SetValue(obj, i);
        }
    }
}
