namespace Pr_02_DistanceCalculator
{
    using System;
    using Pr_01_Point3D;

    public static class Calc
    {
        public static double DistanceCalculator(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt(Math.Pow(secondPoint.PointX - firstPoint.PointX, 2) +
                Math.Pow(secondPoint.PointY - firstPoint.PointY, 2) + 
                Math.Pow(secondPoint.PointZ - firstPoint.PointZ, 2));
            return distance;
        }
    }
}
