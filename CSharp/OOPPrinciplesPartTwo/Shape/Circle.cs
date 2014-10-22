namespace Shape
{
    using System;

    public class Circle : Shape
    {
        private const double Pi = Math.PI;

        public Circle(double radius)
            : base(radius, radius)
        {
        }

        public override double CalculateSurface()
        {
            return Pi * this.Height * this.Width;
        }
    }
}
