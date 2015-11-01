using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_01_Shapes
{
    public class Triangle : BasicShape, IShape
    {
        private double thirdSide;

        public Triangle (double width, double height, double thirdSide) : base(width, height)
        {
            this.ThirdSide = thirdSide;
        }

        public double ThirdSide
        {
            get
            {
                return this.thirdSide;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.thirdSide = value;
            }
        }

        public override double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            double area = Math.Sqrt(p * (p - Width) * (p - Height) * (p - ThirdSide));
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = Width + Height + ThirdSide;
            return perimeter;
        }
    }
}
