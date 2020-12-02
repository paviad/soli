using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightsCompany;
using FlightsCompany.DAL;
using FlightsCompany.Interfaces;

namespace FlightsCompanyWebApi.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase {
        private readonly IRepository _repository;
        private readonly IRegistration _registration;

        public FlightsController(
            IRepository repository,
            IRegistration registration) {
            _repository = repository;
            _registration = registration;
        }

        public void Register(int passengerId, int flightId) {
            var flight = _repository.GetFlight(flightId);
            var passenger = _repository.GetPassenger(passengerId);

            _registration.Register(passenger, flight);
        }
    }
}
