using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicCircularShapeLib
{
    public class Cone:Cylinder
    {
        public Cone(double r, double h) : base(r, h) { }

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
