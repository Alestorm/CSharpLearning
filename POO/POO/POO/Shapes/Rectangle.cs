using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Shapes
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string Color { get; set; }

        public Rectangle(double width, double height, string color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        public void CalculateArea()
        {
            double area = Width * Height;
            Console.WriteLine("Area " + area);
        }
        public void CalculatePerimeter()
        {
            double perimeter = 2 * (Width + Height);
            Console.WriteLine("Perimeter: " + perimeter);
        }
        public void MultiplyScale(int multiplier)
        {
            Console.WriteLine("Multiplied by: " + multiplier);
            Width *= multiplier;
            Height *= multiplier;
        }
        public void Diagonal()
        {
            double diagonal = Math.Sqrt((Math.Pow(Width, 2) + Math.Pow(Height, 2)));
            Console.WriteLine("Diagonal: " + diagonal);
        }
    }
}
