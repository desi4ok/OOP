namespace Pr_01_Point3D
{
    using System;

    class Point3DMain
    {
        static void Main()
        {
            Point3D point = new Point3D(5, 5, 5);
            Console.WriteLine(point);
            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
