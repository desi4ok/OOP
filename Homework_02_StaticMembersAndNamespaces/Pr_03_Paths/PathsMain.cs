using Pr_01_Point3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_03_Paths
{
    class PathsMain
    {
        static void Main(string[] args)
        {
            Path3D path = Storage.ReadData();

            List<Point3D> pathToPrint = path.GetPoints();
            foreach (var point in pathToPrint)
            {
                Console.WriteLine(point.ToString());
            }

            Storage.WriteData(path);
        }
    }
}
