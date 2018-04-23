using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicCircularShapeLib
{
    public class CircularShape
    {
        //fields
        private double r; //radius
        private double h; //height

        public CircularShape(double r,double h)
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
        public virtual double Volume()
        {
            return 0;
        }

        public override string ToString()
        {
            string output = $"name:{GetType().Name}  r:{R.ToString("f3")}  h:{H.ToString("f3")}  area:{Area().ToString("f3")}";
            return output;
        }
    }
}
