namespace Pr_02_DistanceCalculator
{
    using System;
    using Pr_01_Point3D;

    class DistanceCalculatorMain
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(-7, -4, 3);
            Point3D secondPoint = new Point3D(17, 6, 2.5);
            Console.WriteLine(Calc.DistanceCalculator(firstPoint, secondPoint));
        }
    }
}
