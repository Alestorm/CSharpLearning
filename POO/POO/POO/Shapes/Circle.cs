using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Shapes
{
    public class Circle
    {
        public int IdCircle { get; set; }
        public double Radius { get; set; }
        public string Color { get; set; }
        public bool IsFilled { get; set; }

        public Circle(int idCircle, double radius, string color)
        {
            IdCircle = idCircle;
            Radius = radius;
            Color = color;
            IsFilled = false;
        }
        public void CalculateCircumference()
        {
            double circumference = 2 * Math.PI * Radius;
            Console.WriteLine("Circumference: " + circumference);
        }
        public void CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine("Area: " + area);
        }
        public void ToggleFilled()
        {
            IsFilled = !IsFilled;
        }
        public void PrintCircleInfo()
        {
            Console.WriteLine("Circle information");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"IsFilled: {IsFilled}");
            Console.WriteLine($"Diameter: {2 + Radius}");
        }
    }
}
