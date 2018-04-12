using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    public class Circle
    {
        //fields
        private double _radius;
        //constructor
        public Circle(double radius)
        {
            _radius = radius;
        }
        //properties
        public double Radius
        { get { return _radius; } }
        //methods --- Complete code
        public double Area()
        {
            //write this when you did't finish writing the code and wants
            //to run the code without getting error for it
            //throw new InvalidOperationException();

            double area = Math.PI * _radius * _radius;
            return area;
        }
        public double Perimeter()
        {
            double peri = 2 * Math.PI * _radius;
            return peri;
        }
        public double Volume()
        {
            return 0;
        }
    }
}
