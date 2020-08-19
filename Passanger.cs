using System;
using System.Collections.Generic;
using System.Text;

namespace Sharon_MidtermV2
{
    class Passanger
    {
        private int _ID;
        private int _customerID;
        private int _flightID;

        public Passanger(int id, int custId, int flightID)
        {
            ID = id;
            CustomerID = custId;
            FlightID = flightID;
        }
        public int ID { get => _ID; set => _ID = value; }
        public int CustomerID { get => _customerID; set => _customerID = value; }
        public int FlightID { get => _flightID; set => _flightID = value; }

        public override string ToString()
        {
            string pass1 = String.Format("|{0,-9}|{1,-10}|{2,-10}", ID, CustomerID, FlightID);
            return pass1;
        }
    }
}
