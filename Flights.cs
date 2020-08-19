using System;
using System.Collections.Generic;
using System.Text;

namespace Sharon_MidtermV2
{
    class Flights
    {
        private int _ID;
        private int _airlineID;
        private string _DepartureCity;
        private string _DestinationCity;
        private string _DepartureDate;
        private double _FlightTime;

        public Flights(int id, int airID, string departureCity, string destinationCity, string departureDate, double flightTime)
        {
            ID = id;
            AirlineID = airID;
            DepartureCity = departureCity;
            DestinationCity = destinationCity;
            DepartureDate = departureDate;
            FlightTime = flightTime;
        }
        public int ID { get => _ID; set => _ID = value; }
        public int AirlineID { get => _airlineID; set => _airlineID = value; }
        public string DepartureCity { get => _DepartureCity; set => _DepartureCity = value; }
        public string DestinationCity { get => _DestinationCity; set => _DestinationCity = value; }
        public string DepartureDate { get => _DepartureDate; set => _DepartureDate = value; }
        public double FlightTime { get => _FlightTime; set => _FlightTime = value; }

        public override string ToString()
        {
            string flight1 = String.Format("{0,-9}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}", ID, AirlineID, DepartureCity, DestinationCity, DepartureDate, FlightTime);
            return flight1;
        }
    }
}
