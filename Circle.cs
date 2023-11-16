
namespace TestLib
{
    internal class Circle : Figure
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
