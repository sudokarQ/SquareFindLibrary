using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqareFind
{
    // производный класс треугольника
    public class Triangle : Shape
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public bool IsRightTriangle { get; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            // проверка на то, являются ли стороны положительными 
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными");
            }
            // сортировка сторон для проверки на возможность существования треугольника
            double[] sides = new double[3] { firstSide, secondSide, thirdSide };
            Array.Sort(sides);
            Array.Reverse(sides);
            if (sides[0] >= sides[1] + sides[2])
            {
                throw new ArgumentException("Невозможный треугольник");
            }
            // проверка на то, является ли треугольник прямоугольным
            if (sides[0] * sides[0] == sides[1] * sides[1] + sides[2] * sides[2])
            {
                IsRightTriangle = true;
            }
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        // переопрелеление получения площади
        public override double GetArea()
        {
            double p = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
        }

    }
}
