using NUnit.Framework;

namespace FlightsCompanyTests {
    public class RegistrationTests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void CreateFlightTest() {
            var f = new FlightsCompany.Modules.Flight();
            Assert.NotNull(f);
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
