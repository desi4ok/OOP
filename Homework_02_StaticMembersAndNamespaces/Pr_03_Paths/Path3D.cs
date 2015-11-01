namespace Pr_03_Paths
{
    using Pr_01_Point3D;
    using System.Collections.Generic;

    class Path3D
    {
        private List<Point3D> points;

        public Path3D()
        {
            this.points = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public List<Point3D> GetPoints()
        {
            return new List<Point3D>(this.points);
        }
    }
}
