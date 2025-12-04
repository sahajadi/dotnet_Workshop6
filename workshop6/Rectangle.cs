using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop6
{
    internal class Rectangle
    {
        private double length;
        private double breadth;

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        // Expression-bodied method for area
        public double GetArea() => length * breadth;

        // NEW: Expression-bodied method for perimeter
        public double GetPerimeter() => 2 * (length + breadth);

        // Expression-bodied method for showing details
        public string ShowDetails() => $"Length: {length}, Breadth: {breadth}";
    }
}
