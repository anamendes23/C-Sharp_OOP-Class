using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeInterfaceLib
{
    public class Person : IAge
    {
        //fields
        private string _name;
        private DateTime _dateOfBirth;

        public Person(string name, DateTime dateOfBirth)
        {
            _name = name;
            _dateOfBirth = dateOfBirth;
        }

        //properties
        public string Name { get { return _name; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } }
        public int GetAge()
        {
            int yearDiff = DateTime.Now.Year - _dateOfBirth.Year;
            if (DateTime.Now.Month < _dateOfBirth.Month)
            { yearDiff--; }
            return yearDiff;
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
