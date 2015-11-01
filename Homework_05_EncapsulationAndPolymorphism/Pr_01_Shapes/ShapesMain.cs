namespace Pr_01_Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShapesMain
    {
        static void Main()
        {
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Triangle(2, 2, 2));
            shapes.Add(new Rectangle(2, 4));
            shapes.Add(new Circle(5));

            foreach(var shape in shapes)
            {
                double area = shape.CalculateArea();
                double perimeter = shape.CalculatePerimeter();

                Console.WriteLine(shape.GetType() + " area: " + area + ", perimeter: " + perimeter);
            }
        }
    }
}
