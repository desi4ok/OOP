namespace Pr_03_Paths
{
    using Pr_01_Point3D;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    class Storage
    {
        public static Path3D ReadData()
        {
            Path3D paths = new Path3D();
            string line;
            StreamReader sr = new StreamReader("../../input.txt");

            try
            {
                string pattern = "(\\d+[\\.{1}\\d+]*).[^\\.\\d]*(\\d+[\\.{1}\\d+]*).[^\\.\\d]*(\\d+[\\.{1}\\d+]*)";
                line = sr.ReadLine();

                using (sr)
                {
                    while (line != null)
                    {
                        double pointX;
                        double pointY;
                        double pointZ;

                        MatchCollection matches = Regex.Matches(line, pattern);
                        foreach (Match match in matches)
                        {
                            pointX = double.Parse(match.Groups[1].Value);
                            pointY = double.Parse(match.Groups[2].Value);
                            pointZ = double.Parse(match.Groups[3].Value);

                            Point3D point = new Point3D(pointX, pointY, pointZ);
                            paths.AddPoint(point);
                        }
                        line = sr.ReadLine();
                    }
                }
            }

            catch (FileNotFoundException fnf)
            {
                Console.WriteLine("Input.txt not found!" + fnf.Message);
            }
            catch (FileLoadException fle)
            {
                Console.WriteLine("Problem loading Input.txt " + fle.Message);
            }

            finally
            {
                sr.Close();
            }

            return paths;
        }

        public static void WriteData(Path3D paths)
        {
            StreamWriter sw = new StreamWriter("../../output.txt");

            try
            {
                using (sw)
                {
                    List<Point3D> pathToWrite = paths.GetPoints();

                    foreach (Point3D point in pathToWrite)
                    {
                        sw.WriteLine(point.ToString());
                    }
                }
            }

            catch (FileLoadException fle)
            {
                Console.WriteLine("Problem opening OutputPath.txt " + fle.Message);
            }

            finally
            {
                sw.Close();
            }
        }
    }
}
