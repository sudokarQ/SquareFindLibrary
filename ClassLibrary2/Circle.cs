using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqareFind
{
    // производный класс окружности
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительными");
            }

            Radius = radius;
        }
        // переопрелеление получения площади
        public override double GetArea() => Radius * Radius * Math.PI;
    }
}
