using System;

namespace FlightsCompany.Exceptions {
    public class FlightFullException : Exception { }
    public class FlightBaggageWeightExceededException : Exception { }
    public class PersonalBaggageWeightExceededException : Exception { }
    public class PersonalBaggageNumberOfBagsExceededException : Exception { }
}
