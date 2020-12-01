
using NUnit.Framework;

namespace FlightsCompanyTests
{
    public class ModulesTests
    {
        

        [SetUp]
        public void Setup()
        {
            //var _webHost = Microsoft.AspNetCore.WebHost.CreateDefaultBuilder().UseStartup<FlightsCompany.Startup>().Build();
            //Assert.IsNotNull(webHost);
        }

        [Test]
        public void CreateFlightTest()
        {
            var f = new FlightsCompany.Modules.Flight();
            Assert.NotNull(f);
        }

        [Test]
        public void GetFlightsTest()
        {
            //var f = FlightsCompany.Repository.GetFlights();
            //Assert.NotNull(f);
        }


    }
}