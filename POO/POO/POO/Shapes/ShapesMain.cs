using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Shapes
{
    public class ShapesMain
    {
        public void Main()
        {
            Console.WriteLine("SHAPE: Rectangle");
            Rectangle rectangle = new Rectangle(4, 5, "#222");
            rectangle.CalculateArea();
            rectangle.CalculatePerimeter();
            rectangle.Diagonal();

            int multiplier = 3;
            Console.WriteLine("Multiply by " + multiplier);
            rectangle.MultiplyScale(multiplier);
            rectangle.CalculateArea();
            rectangle.Diagonal();

            Console.WriteLine("\nSHAPE: Circle");
            Circle circle = new Circle(1, 2.5, "#222");
            circle.CalculateArea();
            circle.CalculateCircumference();
            circle.PrintCircleInfo();

        }
    }
}
