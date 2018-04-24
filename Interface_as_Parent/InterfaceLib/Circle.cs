using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLib
{
    /* A class can directly inherit from only one class (can have only one parent class, but
     * it can have multiple parent interfaces => it can inherit from multiple interfaces)
     * 
     *      we say: a class inherits from another class
     *      prefer to say: a class implements an interface instead of a class inherits an interface
     *      
     *      when a class implements an interface, it must define all the methods in the
     *      interface, it is by default overriding the methods.The keyword override is not allowed.
     */
    public class Circle : IShape
    {
        //fields
        private double r; // radius
        //constructor
        public Circle(double radius)
        {
            r = radius;
        }
        //properties
        public double R { get { return r; } }
        //methods
        public double Area()
        {
            return Math.PI * r * r;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * r;
        }

        public virtual double Volume()
        {
            return 0;
        }
    }
}
///TO DO:
///Add a second class Rectangle that implements IShape
///in Form1: define a List to hold both circles and rectangles
///add buttons to create random circles and rectangles, add them
///to the list and display them.
///Read/research about interface
