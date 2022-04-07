using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    internal class Rectangular:Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalcArea()
        {
            return Width * Height;
        }
    }
}
