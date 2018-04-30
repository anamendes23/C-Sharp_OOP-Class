using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeInterfaceLib;

namespace LocationInterfaceLib
{
    public class Person : ILocation
    {
        private Address _personAddress;
        private AgeInterfaceLib.Person _person;

        public Person(Address personAddress)
        {
            _personAddress = personAddress;
        }

        public string GetLocation()
        {
            return _personAddress.ToString();
        }
    }
}
