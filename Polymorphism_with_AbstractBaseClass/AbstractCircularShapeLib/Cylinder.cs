using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCircularShapeLib
{
    public class Cylinder : CircularShape
    {
        //constructor
        public Cylinder(double r, double h) : base(r, h) { }
        //methods
        //MAY override Area. Override only if implementtion is different
        public override double Area()
        {
            double a = 2 * Math.PI * R * H;
            return a;
        }
        //MUST override volume since it was declared abstract in the parent class
        public override double Volume()
        {
            double v = Math.PI * R * R * H;
            return v;
        }
    }
}
