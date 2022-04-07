using System;
using System.Collections.Generic;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangular rectangular1 = new Rectangular()
            {
                Height = 10,
                Width= 4
            };
            Rectangular rectangular2 = new Rectangular()
            {
                Height = 13,
                Width = 5
            };
            Rectangular rectangular3 = new Rectangular()
            {
                Height = 15,
                Width = 20
            };

            Circle circle1 = new Circle
            {
                Radius = 5
            };

            Circle circle2 = new Circle
            {
                Radius = 15
            };

            List<Shape> list = new List<Shape>();
            list.Add(rectangular1);
            list.Add(rectangular2);
            list.Add(rectangular3);
            list.Add(circle1);
            list.Add(circle2);





            AreaCalculator areaCalculator = new AreaCalculator();
            Console.WriteLine(areaCalculator.Calc(list));
        }
    }
}
