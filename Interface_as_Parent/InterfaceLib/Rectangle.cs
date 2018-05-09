using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLib
{
    public class Rectangle : IShape
    {
        //fields
        private double _length;
        private double _width;
        //constructor
        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }
        //properties
        public double L { get => _length; }
        public double W { get => _width; }
        //methods
        public double Area()
        {
            return _length * _width;
        }

        public double Perimeter()
        {
            return 2 * (_length + _width);
        }

        public virtual double Volume()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Rectangle - Length: {L:f3} Width: {W:f3} Area: {Area():f3} Peri: {Perimeter():f3} Vol: {Volume():f3}";
        }
    }
}
