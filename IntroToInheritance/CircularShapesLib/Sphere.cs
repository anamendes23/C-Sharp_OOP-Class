using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    public class Sphere : Circle
    {
        //Sphere needs a radius as a parameter, which is already inherited
        //from Circle
        public Sphere(double radius) : base(radius) { }

        //the property Radius is inherited and therefore the Sphere 
        //should not redefine it (unless there are changes to be made)

        //sphere has different implementations for area and volume
        //so it must hide (or redefine) Area and Volume
        new public double Area()
        {
            double a = 4 * Math.PI * Radius * Radius;
            return a;
        }
        new public double Volume()
        {
            double v = 4D / 3D * Math.PI * Math.Pow(Radius, 3);
            return v;
        }
    }
}
