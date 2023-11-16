
namespace TestLib
{
    internal class Triangle : Figure
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override double Area()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter*(semiPerimeter - sideA)*(semiPerimeter - sideB)*(semiPerimeter - sideC));
        }

        //Проверка: является ли треугольник прямоугольным
        public static bool IsRightAngled(double a, double b, double c)
        {
            // Проверка по теореме Пифагора: квадрат самой большой стороны должен быть равен сумме квадратов двух остальных сторон.
            double maxSide = Math.Max(a, Math.Max(b, c));

            if (maxSide == a)
            {
                return IsPythagoreanTheoremSatisfied(a, b, c);
            }
            else if (maxSide == b)
            {
                return IsPythagoreanTheoremSatisfied(b, a, c);
            }
            else
            {
                return IsPythagoreanTheoremSatisfied(c, a, b);
            }
        }

        private static bool IsPythagoreanTheoremSatisfied(double hypotenuse, double side1, double side2)
        {
            return Math.Pow(hypotenuse, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2);
        }
    }

}
