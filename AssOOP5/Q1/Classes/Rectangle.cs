using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP5.Q1.Classes
{
    internal class Rectangle :IRectangle
    {
        public double Area { get; set; }

        public void DisplayShapeInfo()
        {

            Console.WriteLine($"Area of Rectangle= {Area}");
        }
    }
}
