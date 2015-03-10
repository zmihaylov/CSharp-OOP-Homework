namespace ThreeDPoint
{
    public struct Point3D
    {
        private static readonly Point3D start = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public static Point3D Start
        {
            get { return start; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        }
    }
}
