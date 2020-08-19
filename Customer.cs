using System;
using System.Collections.Generic;
using System.Text;

namespace Sharon_MidtermV2
{
    class Customer
    {
        private int _ID;
        private string _Name;
        private string _Address;
        private string _Email;
        private string _phone;

        public Customer()
        {
        }

        public Customer(int id, string name, string address, string email, string phone)
        {
            ID = id;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }
        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Phone { get => _phone; set => _phone = value; }

        public override string ToString()
        {
            string cust1 = String.Format("{0,-9}{1,-10}{2,-10}{3,-10}{4,-10}", ID, Name, Address, Email, Phone);
            return cust1;
        }
    
}
}
