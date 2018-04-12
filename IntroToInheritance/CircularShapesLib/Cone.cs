using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    public class Cone : Cylinder
    {
        //Cone should inherit from Cylinder, because both share the same fields:
        //radius and height
        public Cone(double radius, double height) : base(radius, height) { }

        new public double Area()
        {
            double a = Math.PI * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
            return a;
        }
        new public double Volume()
        {
            double v = Math.PI * Radius * Radius * Height / 3;
            return v;   
        }
    }
}
