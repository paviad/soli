using NUnit.Framework;

namespace FlightsCompanyTests {
    public class RegistrationTests {
        [SetUp]
        public void Setup() {
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
            FlightsCompany.Interfaces.IPassenger passenger = FlightsCompany.Modules.Factory.CreatePassenger();
            FlightsCompany.Interfaces.IBaggage baggage = FlightsCompany.Modules.Factory.CreateBaggage(); 
            FlightsCompany.Interfaces.IFlight flight = FlightsCompany.Modules.Factory.CreateFlight();

            var res = FlightsCompany.Registration.Register(passenger, baggage, flight);
            Assert.NotNull(res);
            Assert.That(res.Status == FlightsCompany.Results.RegistrationResultEnum.Ok);
        }
    }
}
