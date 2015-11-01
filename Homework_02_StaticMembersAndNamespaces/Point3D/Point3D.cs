namespace Pr_01_Point3D
{
    using System;

    public class Point3D
    {
        private static readonly Point3D STARTING_POINT = new Point3D(0, 0, 0);

        public Point3D (double pointX, double pointY, double pointZ)
        {
            this.PointX = pointX;
            this.PointY = pointY;
            this.PointZ = pointZ;
        }

        public double PointX { get; set; }
        public double PointY { get; set; }
        public double PointZ { get; set; }

        public static Point3D StartingPoint
        {
            get { return STARTING_POINT; }
        }

        public override string ToString()
        {
            return String.Format("Point coordinates: ({0}, {1}, {2})", this.PointX, this.PointY, this.PointZ);
        }
    }
}
