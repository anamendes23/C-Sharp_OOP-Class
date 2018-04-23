using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCircularShapeLib
{
    public class Cone : Cylinder
    {
        //constructor
        public Cone(double r, double h) : base(r, h) { }
        //methods
        public override double Area()
        {
            double area = Math.PI * R * (R + Math.Sqrt(R * R + H * H));
            return area;
        }
        public override double Volume()
        {
            double volume = Math.PI * R * R * H / 3;
            return volume;
        }
    }
}
