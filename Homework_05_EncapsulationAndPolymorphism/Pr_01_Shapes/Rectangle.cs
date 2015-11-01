using System;

namespace Pr_01_Shapes
{
    class Rectangle : BasicShape, IShape
    {
        public Rectangle (double width, double height) : base(width, height) { }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}
