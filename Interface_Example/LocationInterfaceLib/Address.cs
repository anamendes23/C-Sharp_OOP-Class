using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationInterfaceLib
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _zipcode;

        public Address(string street, string city, string state, string zipcode)
        {
            _street = street;
            _city = city;
            _state = state;
            _zipcode = zipcode;
        }

        public string Street { get => _street; }
        public string City { get => _city; }
        public string State { get => _state; }
        public string Zipcode { get => _zipcode; }

        public override string ToString()
        {
            return $"{Street}\n,{City}, {State} {Zipcode}";
        }
    }
}
