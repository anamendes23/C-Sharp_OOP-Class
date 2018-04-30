using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationInterfaceLib
{
    public class Person : ILocation
    {
        private Address _personAddress;

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
