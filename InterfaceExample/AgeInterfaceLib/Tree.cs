using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeInterfaceLib
{
    public class Tree : IAge
    {
        private string _name;
        private DateTime _datePlanted;

        public Tree(string name, DateTime datePlanted)
        {
            _name = name;
            _datePlanted = datePlanted;
        }

        public string Name { get { return _name; } }
        public DateTime DatePlanted
        {
            get { return _datePlanted; }
            set { _datePlanted = value; }
        }
        public int GetAge()
        {
            int yearDiff = DateTime.Now.Year - _datePlanted.Year;
            if (DateTime.Now.Month < _datePlanted.Month)
            { yearDiff--; }
            return yearDiff;
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
