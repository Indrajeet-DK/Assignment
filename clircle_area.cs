using Assignment_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndDiameterOfCircle
{
    internal class circle
    {
        double radius;
        double diameter;

        public double Radius { get; set; }
        public double Diameter { get; set; }


        double getArea()
        {
            return Math.PI * Radius * Radius;
        }

        double getDiameter()
        {
            return Radius * 2;
        }



        public static void Main()
        {
            circle radiusanddia = new circle { Radius =10, Diameter = 20 };
            double area = radiusanddia.getArea();
            Console.WriteLine($"the area of the circle is {area} ");
            double diameter = radiusanddia.getDiameter();
            Console.WriteLine($"the diameter of the circle is{diameter}");

        }

    }
}
