using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicCircularShapeLib
{
    public class Sphere : Circle
    {
        public Sphere(double r) : base(r) { }

        public override double Area()
        {
            double a = 4 * Math.PI * R * R;
            return a;
        }
        public override double Volume()
        {
            double v = 4D / 3D * Math.PI * Math.Pow(R, 3);
            return v;
        }
    }
}
