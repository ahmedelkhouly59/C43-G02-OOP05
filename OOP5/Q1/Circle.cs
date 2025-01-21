using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.Q1
{
    internal class Circle: Icircle
    {
        public double Radius { get; set; }

        public double Area { get; set; }

        public Circle() { }
        public Circle(double r) {
            Radius = r;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius is {Radius} \nArea is {calculateArea()}");
        }

        public double calculateArea()
        {
            return 3.14 * (Math.Pow(Radius,2));
        }

    }
}
