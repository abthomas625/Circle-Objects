using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    internal class Circle
    {
        public double Radius { get; set; }
        //public double CirclesMade { get; set; } = 0;

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        //circumference = 2*PI*radius
        public double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return Math.Round(circumference, 2);
        }
        //area = PI*radius squared
        public double CalculateArea(double radius)
        {
            double area = Math.PI * (radius * radius);
            return Math.Round(area, 2);
        }
    }

    
}


