using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquitable_Interface_Example
{
    public class Box : IEquatable<Box>
    {
        //fields
        private int length;
        private int width;
        private int height;
        //constructor
        public Box(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        //properties
        public int Length { get => length; }
        public int Width { get => width; }
        public int Height { get => height; }
        //methods
        public int Volume()
        {
            return length * width * height;
        }
        public bool Equals(Box other)
        {
            //is this box equal to the other box?
            //use your own criteria for defining what it means
            //for two boxes to be equal.
            //may be: all sides must be equal
            //may be: just the volumes must be equal

            if (this.Volume() == other.Volume())
                return true;

            return false;
        }
        public override string ToString()
        {
            return $"L: {length} W: {width} H: {height} V: {Volume()}";
        }
    }
}
