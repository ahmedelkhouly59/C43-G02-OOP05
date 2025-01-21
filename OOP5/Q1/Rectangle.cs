using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.Q1
{
    internal class Rectangle:Irectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }


        public Rectangle(double width, double height)
        {
            Length = width; 
            Width = height;
        }

        public Rectangle() { }
        public double Area { get; set; }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Length is {Length} \nWidth is {Width} \nArea is {calculateArea()}");
        }

        public double calculateArea()
        {
            return (Length * Width);
        }
    }
}
