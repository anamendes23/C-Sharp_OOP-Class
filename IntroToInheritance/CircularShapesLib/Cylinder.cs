using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    //if a class does not define a constructor (has no constructor)
    //the compiler will provide a default constructor to allow you to
    //create an object of the class.
    //However, if you provide a constructor, the compiler will not provide
    //a default constructor. If you need a default constructor, you will
    //have to add it yourself.
    public class Cylinder : Circle
    {
        //define additional private fields that pertain to this class
        //but not to the Parent Class (Circle)
        private double _height;
        //the Cylinder has actually 2 fields: _radius(inherited), _height
        //constructor
        public Cylinder(double radius, double height) : base(radius)
        {
            _height = height;
        }
        //property
        public double Height { get { return _height; } }
        //Method Hiding: allowing this child to redefine some or all
        //of the inherited methods (or properties)

        //since the cylinder is ok with the formula in the Circle perimeter
        //there is no need to redefine it.

        //however, the cylinder uses different formulas for Area and Volume,
        //we should redefine both Areas and Volume
        //make sure to write the method name exactly as defined in the parent
        new public double Area()
        {
            double a = 2 * Math.PI * Radius * _height;
            return a;
        }
        new public double Volume()
        {
            double v = Math.PI * Radius * Radius * _height;
            return v;
        }
    }
}
