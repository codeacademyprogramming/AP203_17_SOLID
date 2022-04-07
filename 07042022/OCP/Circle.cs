using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    internal class Circle:Shape
    {
        public double Radius { get; set; }

        public override double CalcArea()
        {
            return Radius* Radius * Math.PI;
        }
    }
}
