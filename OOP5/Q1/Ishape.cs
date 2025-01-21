using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal interface Ishape
    {
        public double Area { get; set; }

        public void DisplayShapeInfo();

        public double calculateArea();

    }
}
