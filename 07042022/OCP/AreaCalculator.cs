using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    internal class AreaCalculator
    {
        public double Calc(List<Shape> shapes)
        {
            double area = 0;    
            foreach (var item in shapes)
            {
                area += item.CalcArea();
            }

            return area;
        }
    }
}
