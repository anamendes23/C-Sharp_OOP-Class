using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCircularShapeLib
{
    public class Circle : CircularShape
    {
        public Circle(double r) : base(r, 0) { }
        //Since Volume was declared abstract in the parent class, a child 
        //class MUST override it.
        public override double Volume()
        {
            return 0;
        }
    }
}
