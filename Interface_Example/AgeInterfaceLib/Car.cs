using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    public class Car : IAge
    {
        private string _name;
        private DateTime _dateManufactured;

        public Car(string name, DateTime dateManufactured)
        {
            _name = name;
            _dateManufactured = dateManufactured;
        }

        public DateTime DateManufactured { get => _dateManufactured; set => _dateManufactured = value; }
        public string Name { get => _name; set => _name = value; }

        public int GetAge()
        {
            int yearDiff = DateTime.Now.Year - DateManufactured.Year;
            if (DateTime.Now.Month < DateManufactured.Month)
            { yearDiff--; }
            return yearDiff;
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
