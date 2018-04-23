using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCircularShapeLib
{
    public abstract class CircularShape
    {
        //fields
        private double r; //radius
        private double h; //height
        //constructor
        public CircularShape(double r, double h)
        {
            this.r = r;
            this.h = h;
        }
        //properties
        public virtual double R { get { return this.r; } }
        public virtual double H { get { return this.h; } }

        //methods
        public virtual double Area()
        {
            double area = Math.PI * r * r;
            return area;
        }
        public virtual double Perimeter()
        {
            double peri = 2 * Math.PI * r;
            return peri;
        }
        //virtual: may override
        //abstract: must override
        //an abstract method cannot have a body (no implementation)
        //an abstract method MUST be defined within an abstract class
        //so this class MUST be abstract
        public abstract double Volume();

        public override string ToString()
        {
            string output = $"name:{GetType().Name}  r:{R.ToString("f3")}  h:{H.ToString("f3")}  area:{Area().ToString("f3")}";
            return output;
        }
    }
}
