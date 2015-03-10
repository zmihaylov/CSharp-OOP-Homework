namespace ThreeDPoint
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        private List<Point3D> paths;

        public Path()
        {
            this.paths = new List<Point3D>();
            AddStartPoint();
        }

        private void AddStartPoint()
        {
            this.paths.Add(Point3D.Start);
        }

        public void AddPoint(Point3D point)
        {
            this.paths.Add(point);
        }

        public void AddPoint(int x, int y, int z)
        {
            this.paths.Add(new Point3D(x, y, z));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int pathIndexer = 0;

            foreach (var point in this.paths)
            {
                sb.AppendFormat("Point #{0} ---> ", pathIndexer);
                pathIndexer++;
                sb.AppendFormat(point.ToString() + "\r\n");
            }
            return sb.ToString();
        }
    }
}
